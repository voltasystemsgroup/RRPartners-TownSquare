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

namespace UserModule_UC_DMX_DYNAMIC_FIXTURE_CONTROL__ULTAMATION__V1_00
{
    public class UserModuleClass_UC_DMX_DYNAMIC_FIXTURE_CONTROL__ULTAMATION__V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> CHANNEL;
        Crestron.Logos.SplusObjects.StringOutput OUT__DOLLAR__;
        UShortParameter START_CHANNEL;
        ushort G_INUMCHANNELS = 0;
        CrestronString G_SOUTPUT;
        ushort G_IBUSY = 0;
        object SEND_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 94;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IBUSY == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 97;
                    G_IBUSY = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( G_SOUTPUT , "S:0000:{0:X4}:{1:X4}:", START_CHANNEL  .Value, (G_INUMCHANNELS * 2)) ; 
                    __context__.SourceCodeLine = 103;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)G_INUMCHANNELS; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 106;
                        MakeString ( G_SOUTPUT , "{0}{1:X2}", G_SOUTPUT , (CHANNEL[ I ] .UshortValue / 256)) ; 
                        __context__.SourceCodeLine = 103;
                        } 
                    
                    __context__.SourceCodeLine = 110;
                    OUT__DOLLAR__  .UpdateValue ( G_SOUTPUT  ) ; 
                    __context__.SourceCodeLine = 113;
                    G_IBUSY = (ushort) ( 0 ) ; 
                    } 
                
                
                
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
            
            __context__.SourceCodeLine = 126;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 100 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( G_INUMCHANNELS  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G_INUMCHANNELS  >= __FN_FORSTART_VAL__1) && (G_INUMCHANNELS  <= __FN_FOREND_VAL__1) ) : ( (G_INUMCHANNELS  <= __FN_FORSTART_VAL__1) && (G_INUMCHANNELS  >= __FN_FOREND_VAL__1) ) ; G_INUMCHANNELS  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 127;
                if ( Functions.TestForTrue  ( ( IsSignalDefined( CHANNEL[ G_INUMCHANNELS ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 128;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 126;
                }
            
            __context__.SourceCodeLine = 131;
            G_IBUSY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 134;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        G_SOUTPUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1042, this );
        
        SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
        m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
        
        CHANNEL = new InOutArray<AnalogInput>( 100, this );
        for( uint i = 0; i < 100; i++ )
        {
            CHANNEL[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( CHANNEL__AnalogSerialInput__ + i, CHANNEL__AnalogSerialInput__, this );
            m_AnalogInputList.Add( CHANNEL__AnalogSerialInput__ + i, CHANNEL[i+1] );
        }
        
        OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__, OUT__DOLLAR__ );
        
        START_CHANNEL = new UShortParameter( START_CHANNEL__Parameter__, this );
        m_ParameterList.Add( START_CHANNEL__Parameter__, START_CHANNEL );
        
        
        SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_UC_DMX_DYNAMIC_FIXTURE_CONTROL__ULTAMATION__V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SEND__DigitalInput__ = 0;
    const uint CHANNEL__AnalogSerialInput__ = 0;
    const uint OUT__DOLLAR____AnalogSerialOutput__ = 0;
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