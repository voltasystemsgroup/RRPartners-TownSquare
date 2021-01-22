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

namespace UserModule_DEVICE_PWR_CONTROLLER
{
    public class UserModuleClass_DEVICE_PWR_CONTROLLER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PWR_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT;
        Crestron.Logos.SplusObjects.DigitalOutput SEND_PWR_ON;
        Crestron.Logos.SplusObjects.DigitalOutput SEND_PWR_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SEND_INPUT;
        UShortParameter DELAYED_INPUT_TRIGGER;
        UShortParameter PULSE_TIME;
        UShortParameter STEP_TIME;
        ushort STATE = 0;
        private void STATECHANGE (  SplusExecutionContext __context__, ushort NEWSTATE ) 
            { 
            
            __context__.SourceCodeLine = 134;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 135;
                Functions.Pulse ( PULSE_TIME  .Value, SEND_PWR_ON ) ; 
                __context__.SourceCodeLine = 136;
                Functions.Delay (  (int) ( (STEP_TIME  .Value + PULSE_TIME  .Value) ) ) ; 
                __context__.SourceCodeLine = 137;
                Functions.Pulse ( PULSE_TIME  .Value, SEND_INPUT [ NEWSTATE] ) ; 
                __context__.SourceCodeLine = 139;
                CreateWait ( "PWR_LONG_DELAY" , DELAYED_INPUT_TRIGGER  .Value , PWR_LONG_DELAY_Callback ) ;
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 143;
                Functions.Pulse ( PULSE_TIME  .Value, SEND_PWR_ON ) ; 
                __context__.SourceCodeLine = 144;
                Functions.Delay (  (int) ( (STEP_TIME  .Value + PULSE_TIME  .Value) ) ) ; 
                __context__.SourceCodeLine = 145;
                Functions.Pulse ( PULSE_TIME  .Value, SEND_INPUT [ NEWSTATE] ) ; 
                } 
            
            
            }
            
        public void PWR_LONG_DELAY_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 140;
            Functions.Pulse ( PULSE_TIME  .Value, SEND_INPUT [ STATE] ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object INPUT_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort SRC = 0;
            
            
            __context__.SourceCodeLine = 152;
            SRC = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 154;
            CancelWait ( "PWR_LONG_DELAY" ) ; 
            __context__.SourceCodeLine = 155;
            STATECHANGE (  __context__ , (ushort)( SRC )) ; 
            __context__.SourceCodeLine = 156;
            STATE = (ushort) ( SRC ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PWR_OFF_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 161;
        CancelWait ( "PWR_LONG_DELAY" ) ; 
        __context__.SourceCodeLine = 162;
        Functions.Pulse ( PULSE_TIME  .Value, SEND_PWR_OFF ) ; 
        __context__.SourceCodeLine = 163;
        STATE = (ushort) ( 0 ) ; 
        
        
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
        
        __context__.SourceCodeLine = 174;
        STATE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    PWR_OFF = new Crestron.Logos.SplusObjects.DigitalInput( PWR_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( PWR_OFF__DigitalInput__, PWR_OFF );
    
    INPUT = new InOutArray<DigitalInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        INPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT__DigitalInput__ + i, INPUT__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT__DigitalInput__ + i, INPUT[i+1] );
    }
    
    SEND_PWR_ON = new Crestron.Logos.SplusObjects.DigitalOutput( SEND_PWR_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SEND_PWR_ON__DigitalOutput__, SEND_PWR_ON );
    
    SEND_PWR_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( SEND_PWR_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( SEND_PWR_OFF__DigitalOutput__, SEND_PWR_OFF );
    
    SEND_INPUT = new InOutArray<DigitalOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        SEND_INPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SEND_INPUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SEND_INPUT__DigitalOutput__ + i, SEND_INPUT[i+1] );
    }
    
    DELAYED_INPUT_TRIGGER = new UShortParameter( DELAYED_INPUT_TRIGGER__Parameter__, this );
    m_ParameterList.Add( DELAYED_INPUT_TRIGGER__Parameter__, DELAYED_INPUT_TRIGGER );
    
    PULSE_TIME = new UShortParameter( PULSE_TIME__Parameter__, this );
    m_ParameterList.Add( PULSE_TIME__Parameter__, PULSE_TIME );
    
    STEP_TIME = new UShortParameter( STEP_TIME__Parameter__, this );
    m_ParameterList.Add( STEP_TIME__Parameter__, STEP_TIME );
    
    PWR_LONG_DELAY_Callback = new WaitFunction( PWR_LONG_DELAY_CallbackFn );
    
    for( uint i = 0; i < 20; i++ )
        INPUT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_OnPush_0, false ) );
        
    PWR_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( PWR_OFF_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DEVICE_PWR_CONTROLLER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction PWR_LONG_DELAY_Callback;


const uint PWR_OFF__DigitalInput__ = 0;
const uint INPUT__DigitalInput__ = 1;
const uint SEND_PWR_ON__DigitalOutput__ = 0;
const uint SEND_PWR_OFF__DigitalOutput__ = 1;
const uint SEND_INPUT__DigitalOutput__ = 2;
const uint DELAYED_INPUT_TRIGGER__Parameter__ = 10;
const uint PULSE_TIME__Parameter__ = 11;
const uint STEP_TIME__Parameter__ = 12;

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
