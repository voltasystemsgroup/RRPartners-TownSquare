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

namespace UserModule_PG_EQUIPID_VERIFY_V1_1
{
    public class UserModuleClass_PG_EQUIPID_VERIFY_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput EQUIP_ID_IN;
        Crestron.Logos.SplusObjects.DigitalOutput IS_VALID;
        Crestron.Logos.SplusObjects.AnalogOutput EQUIP_ID_OUT;
        object EQUIP_ID_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ID = 0;
                
                
                __context__.SourceCodeLine = 62;
                ID = (ushort) ( EQUIP_ID_IN  .UshortValue ) ; 
                __context__.SourceCodeLine = 63;
                IS_VALID  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 64;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ID > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    EQUIP_ID_OUT  .Value = (ushort) ( ID ) ; 
                    __context__.SourceCodeLine = 67;
                    IS_VALID  .Value = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        IS_VALID = new Crestron.Logos.SplusObjects.DigitalOutput( IS_VALID__DigitalOutput__, this );
        m_DigitalOutputList.Add( IS_VALID__DigitalOutput__, IS_VALID );
        
        EQUIP_ID_IN = new Crestron.Logos.SplusObjects.AnalogInput( EQUIP_ID_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( EQUIP_ID_IN__AnalogSerialInput__, EQUIP_ID_IN );
        
        EQUIP_ID_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( EQUIP_ID_OUT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( EQUIP_ID_OUT__AnalogSerialOutput__, EQUIP_ID_OUT );
        
        
        EQUIP_ID_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( EQUIP_ID_IN_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PG_EQUIPID_VERIFY_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint EQUIP_ID_IN__AnalogSerialInput__ = 0;
    const uint IS_VALID__DigitalOutput__ = 0;
    const uint EQUIP_ID_OUT__AnalogSerialOutput__ = 0;
    
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
