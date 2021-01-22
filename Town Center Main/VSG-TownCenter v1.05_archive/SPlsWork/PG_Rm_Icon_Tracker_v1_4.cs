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

namespace UserModule_PG_RM_ICON_TRACKER_V1_4
{
    public class UserModuleClass_PG_RM_ICON_TRACKER_V1_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DEVICE_TRIGGER;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> DEVICE_ICON;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> DEVICE_NAME;
        Crestron.Logos.SplusObjects.AnalogOutput SRC_ICON;
        Crestron.Logos.SplusObjects.StringOutput SRC_NAME;
        object DEVICE_TRIGGER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 66;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 68;
                SRC_ICON  .Value = (ushort) ( DEVICE_ICON[ I ] .UshortValue ) ; 
                __context__.SourceCodeLine = 69;
                SRC_NAME  .UpdateValue ( DEVICE_NAME [ I ]  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        DEVICE_TRIGGER = new InOutArray<DigitalInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            DEVICE_TRIGGER[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DEVICE_TRIGGER__DigitalInput__ + i, DEVICE_TRIGGER__DigitalInput__, this );
            m_DigitalInputList.Add( DEVICE_TRIGGER__DigitalInput__ + i, DEVICE_TRIGGER[i+1] );
        }
        
        DEVICE_ICON = new InOutArray<AnalogInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            DEVICE_ICON[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( DEVICE_ICON__AnalogSerialInput__ + i, DEVICE_ICON__AnalogSerialInput__, this );
            m_AnalogInputList.Add( DEVICE_ICON__AnalogSerialInput__ + i, DEVICE_ICON[i+1] );
        }
        
        SRC_ICON = new Crestron.Logos.SplusObjects.AnalogOutput( SRC_ICON__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( SRC_ICON__AnalogSerialOutput__, SRC_ICON );
        
        DEVICE_NAME = new InOutArray<StringInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            DEVICE_NAME[i+1] = new Crestron.Logos.SplusObjects.StringInput( DEVICE_NAME__AnalogSerialInput__ + i, DEVICE_NAME__AnalogSerialInput__, 255, this );
            m_StringInputList.Add( DEVICE_NAME__AnalogSerialInput__ + i, DEVICE_NAME[i+1] );
        }
        
        SRC_NAME = new Crestron.Logos.SplusObjects.StringOutput( SRC_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SRC_NAME__AnalogSerialOutput__, SRC_NAME );
        
        
        for( uint i = 0; i < 50; i++ )
            DEVICE_TRIGGER[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DEVICE_TRIGGER_OnPush_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PG_RM_ICON_TRACKER_V1_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DEVICE_TRIGGER__DigitalInput__ = 0;
    const uint DEVICE_ICON__AnalogSerialInput__ = 0;
    const uint DEVICE_NAME__AnalogSerialInput__ = 50;
    const uint SRC_ICON__AnalogSerialOutput__ = 0;
    const uint SRC_NAME__AnalogSerialOutput__ = 1;
    
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
