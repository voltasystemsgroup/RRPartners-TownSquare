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

namespace UserModule_PG_PROJ_STATUS_TEXT_V1_0
{
    public class UserModuleClass_PG_PROJ_STATUS_TEXT_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput WARMING_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput COOLING_ACTIVE;
        Crestron.Logos.SplusObjects.AnalogInput WARMING_TIMER;
        Crestron.Logos.SplusObjects.AnalogInput COOLING_TIMER;
        Crestron.Logos.SplusObjects.StringOutput STATUS_TEXT;
        object WARMING_TIMER_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 66;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WARMING_ACTIVE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 67;
                    MakeString ( STATUS_TEXT , "WARMING UP... {0}", Functions.ItoA (  (int) ( WARMING_TIMER  .UshortValue ) ) ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object COOLING_TIMER_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COOLING_ACTIVE  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 73;
                MakeString ( STATUS_TEXT , "COOLING DOWN... {0}", Functions.ItoA (  (int) ( COOLING_TIMER  .UshortValue ) ) ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object WARMING_ACTIVE_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 78;
        MakeString ( STATUS_TEXT , " ") ; 
        
        
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
        
        __context__.SourceCodeLine = 88;
        MakeString ( STATUS_TEXT , " ") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    WARMING_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( WARMING_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( WARMING_ACTIVE__DigitalInput__, WARMING_ACTIVE );
    
    COOLING_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( COOLING_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( COOLING_ACTIVE__DigitalInput__, COOLING_ACTIVE );
    
    WARMING_TIMER = new Crestron.Logos.SplusObjects.AnalogInput( WARMING_TIMER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( WARMING_TIMER__AnalogSerialInput__, WARMING_TIMER );
    
    COOLING_TIMER = new Crestron.Logos.SplusObjects.AnalogInput( COOLING_TIMER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COOLING_TIMER__AnalogSerialInput__, COOLING_TIMER );
    
    STATUS_TEXT = new Crestron.Logos.SplusObjects.StringOutput( STATUS_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATUS_TEXT__AnalogSerialOutput__, STATUS_TEXT );
    
    
    WARMING_TIMER.OnAnalogChange.Add( new InputChangeHandlerWrapper( WARMING_TIMER_OnChange_0, false ) );
    COOLING_TIMER.OnAnalogChange.Add( new InputChangeHandlerWrapper( COOLING_TIMER_OnChange_1, false ) );
    WARMING_ACTIVE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( WARMING_ACTIVE_OnRelease_2, false ) );
    COOLING_ACTIVE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( WARMING_ACTIVE_OnRelease_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PG_PROJ_STATUS_TEXT_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint WARMING_ACTIVE__DigitalInput__ = 0;
const uint COOLING_ACTIVE__DigitalInput__ = 1;
const uint WARMING_TIMER__AnalogSerialInput__ = 0;
const uint COOLING_TIMER__AnalogSerialInput__ = 1;
const uint STATUS_TEXT__AnalogSerialOutput__ = 0;

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
