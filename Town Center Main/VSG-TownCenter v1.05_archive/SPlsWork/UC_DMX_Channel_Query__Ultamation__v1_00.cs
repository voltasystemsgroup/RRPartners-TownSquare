using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_UC_DMX_CHANNEL_QUERY__ULTAMATION__V1_00
{
    public class UserModuleClass_UC_DMX_CHANNEL_QUERY__ULTAMATION__V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput QUERY;
        Crestron.Logos.SplusObjects.StringInput TCP_IN;
        Crestron.Logos.SplusObjects.DigitalOutput COMPLETE;
        Crestron.Logos.SplusObjects.StringOutput TCP_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> CHANNEL;
        UShortParameter START_CHANNEL;
        ushort G_INUMCHANNELS = 0;
        CrestronString G_SOUTPUT;
        ushort G_IBUSY = 0;
        object QUERY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort IREPLYLEN = 0;
                
                ushort IPAYLOADLEN = 0;
                
                ushort I = 0;
                
                ushort ITEMPCHANNEL = 0;
                
                CrestronString SBYTE;
                SBYTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
                
                CrestronString SRECEIVED;
                SRECEIVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IBUSY == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 99;
                    G_IBUSY = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 102;
                    MakeString ( TCP_OUT , "G:0000:{0:X4}:0004:{1:X4}", START_CHANNEL  .Value, G_INUMCHANNELS) ; 
                    __context__.SourceCodeLine = 105;
                    IREPLYLEN = (ushort) ( ((G_INUMCHANNELS * 2) + 17) ) ; 
                    __context__.SourceCodeLine = 107;
                    /* Trace( "Command sent, awaiting response. Return len should be {0:d}", (short)IREPLYLEN) */ ; 
                    __context__.SourceCodeLine = 110;
                    SRECEIVED  .UpdateValue ( Functions.Gather ( IREPLYLEN, TCP_IN , 100)  ) ; 
                    __context__.SourceCodeLine = 112;
                    /* Trace( "sReceived Length = {0:d}", (short)Functions.Length( SRECEIVED )) */ ; 
                    __context__.SourceCodeLine = 115;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SRECEIVED ) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 119;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( SRECEIVED , (int)( 7 ) ) == "F:0000:") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.HextoI( Functions.Mid( SRECEIVED , (int)( 8 ) , (int)( 4 ) ) ) == START_CHANNEL  .Value) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 121;
                            /* Trace( "Response is feedback and matches start channel") */ ; 
                            __context__.SourceCodeLine = 124;
                            IPAYLOADLEN = (ushort) ( Functions.HextoI( Functions.Mid( SRECEIVED , (int)( 13 ) , (int)( 4 ) ) ) ) ; 
                            __context__.SourceCodeLine = 126;
                            /* Trace( "Payload Length = {0:d}", (short)IPAYLOADLEN) */ ; 
                            __context__.SourceCodeLine = 129;
                            SRECEIVED  .UpdateValue ( Functions.Right ( SRECEIVED ,  (int) ( IPAYLOADLEN ) )  ) ; 
                            __context__.SourceCodeLine = 131;
                            /* Trace( "Payload = {0}", SRECEIVED ) */ ; 
                            __context__.SourceCodeLine = 134;
                            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                            ushort __FN_FOREND_VAL__1 = (ushort)G_INUMCHANNELS; 
                            int __FN_FORSTEP_VAL__1 = (int)1; 
                            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                                { 
                                __context__.SourceCodeLine = 136;
                                /* Trace( "Processing Channel {0:d}", (short)I) */ ; 
                                __context__.SourceCodeLine = 140;
                                SBYTE  .UpdateValue ( Functions.Remove ( 2, SRECEIVED )  ) ; 
                                __context__.SourceCodeLine = 141;
                                /* Trace( "Value byte = {0}", SBYTE ) */ ; 
                                __context__.SourceCodeLine = 143;
                                ITEMPCHANNEL = (ushort) ( Functions.HextoI( SBYTE ) ) ; 
                                __context__.SourceCodeLine = 144;
                                CHANNEL [ I]  .Value = (ushort) ( (ITEMPCHANNEL + (ITEMPCHANNEL << 8)) ) ; 
                                __context__.SourceCodeLine = 147;
                                /* Trace( "Value int = {0:d}", (short)Functions.HextoI( SBYTE )) */ ; 
                                __context__.SourceCodeLine = 134;
                                } 
                            
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 155;
                Functions.ClearBuffer ( TCP_IN ) ; 
                __context__.SourceCodeLine = 156;
                Functions.Pulse ( 50, COMPLETE ) ; 
                __context__.SourceCodeLine = 157;
                G_IBUSY = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 169;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 100 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( G_INUMCHANNELS  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G_INUMCHANNELS  >= __FN_FORSTART_VAL__1) && (G_INUMCHANNELS  <= __FN_FOREND_VAL__1) ) : ( (G_INUMCHANNELS  <= __FN_FORSTART_VAL__1) && (G_INUMCHANNELS  >= __FN_FOREND_VAL__1) ) ; G_INUMCHANNELS  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 170;
                if ( Functions.TestForTrue  ( ( IsSignalDefined( CHANNEL[ G_INUMCHANNELS ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 171;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 169;
                }
            
            __context__.SourceCodeLine = 174;
            G_IBUSY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 177;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        G_SOUTPUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
        
        QUERY = new Crestron.Logos.SplusObjects.DigitalInput( QUERY__DigitalInput__, this );
        m_DigitalInputList.Add( QUERY__DigitalInput__, QUERY );
        
        COMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( COMPLETE__DigitalOutput__, this );
        m_DigitalOutputList.Add( COMPLETE__DigitalOutput__, COMPLETE );
        
        CHANNEL = new InOutArray<AnalogOutput>( 512, this );
        for( uint i = 0; i < 512; i++ )
        {
            CHANNEL[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( CHANNEL__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( CHANNEL__AnalogSerialOutput__ + i, CHANNEL[i+1] );
        }
        
        TCP_IN = new Crestron.Logos.SplusObjects.StringInput( TCP_IN__AnalogSerialInput__, 512, this );
        m_StringInputList.Add( TCP_IN__AnalogSerialInput__, TCP_IN );
        
        TCP_OUT = new Crestron.Logos.SplusObjects.StringOutput( TCP_OUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( TCP_OUT__AnalogSerialOutput__, TCP_OUT );
        
        START_CHANNEL = new UShortParameter( START_CHANNEL__Parameter__, this );
        m_ParameterList.Add( START_CHANNEL__Parameter__, START_CHANNEL );
        
        
        QUERY.OnDigitalPush.Add( new InputChangeHandlerWrapper( QUERY_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_UC_DMX_CHANNEL_QUERY__ULTAMATION__V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint QUERY__DigitalInput__ = 0;
    const uint TCP_IN__AnalogSerialInput__ = 0;
    const uint COMPLETE__DigitalOutput__ = 0;
    const uint TCP_OUT__AnalogSerialOutput__ = 0;
    const uint CHANNEL__AnalogSerialOutput__ = 1;
    const uint START_CHANNEL__Parameter__ = 10;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
