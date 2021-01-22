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

namespace UserModule_PG_RM_EQUIPID_CONVERTER_V1_4
{
    public class UserModuleClass_PG_RM_EQUIPID_CONVERTER_V1_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput SRC_ID;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> DEVICE_ID;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DEVICE_TRIGGER;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_SRC_ID;
        object SRC_ID_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                ushort SRC_FOUND = 0;
                ushort TESTING_SRC = 0;
                
                
                __context__.SourceCodeLine = 65;
                TESTING_SRC = (ushort) ( SRC_ID  .UshortValue ) ; 
                __context__.SourceCodeLine = 67;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TESTING_SRC < 1 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 68;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 71;
                SRC_FOUND = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 72;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)50; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 74;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TESTING_SRC == DEVICE_ID[ I ] .UshortValue))  ) ) 
                        { 
                        __context__.SourceCodeLine = 76;
                        SRC_FOUND = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 77;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 72;
                    } 
                
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SRC_FOUND == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 82;
                    Functions.Pulse ( 50, DEVICE_TRIGGER [ I] ) ; 
                    __context__.SourceCodeLine = 83;
                    CURRENT_SRC_ID  .Value = (ushort) ( TESTING_SRC ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        DEVICE_TRIGGER = new InOutArray<DigitalOutput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            DEVICE_TRIGGER[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DEVICE_TRIGGER__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( DEVICE_TRIGGER__DigitalOutput__ + i, DEVICE_TRIGGER[i+1] );
        }
        
        SRC_ID = new Crestron.Logos.SplusObjects.AnalogInput( SRC_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( SRC_ID__AnalogSerialInput__, SRC_ID );
        
        DEVICE_ID = new InOutArray<AnalogInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            DEVICE_ID[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID__AnalogSerialInput__, this );
            m_AnalogInputList.Add( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID[i+1] );
        }
        
        CURRENT_SRC_ID = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_SRC_ID__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CURRENT_SRC_ID__AnalogSerialOutput__, CURRENT_SRC_ID );
        
        
        SRC_ID.OnAnalogChange.Add( new InputChangeHandlerWrapper( SRC_ID_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PG_RM_EQUIPID_CONVERTER_V1_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SRC_ID__AnalogSerialInput__ = 0;
    const uint DEVICE_ID__AnalogSerialInput__ = 1;
    const uint DEVICE_TRIGGER__DigitalOutput__ = 0;
    const uint CURRENT_SRC_ID__AnalogSerialOutput__ = 0;
    
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
