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

namespace UserModule_PG_ACTIONLIST_ICONDRIVER_V1_3
{
    public class UserModuleClass_PG_ACTIONLIST_ICONDRIVER_V1_3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> AL_PRESS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> AL_ENABLE;
        Crestron.Logos.SplusObjects.AnalogInput AL_BLANKICON;
        Crestron.Logos.SplusObjects.AnalogInput AL_SIZE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> AL_ICON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> AL_PRESS_OUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> AL_ENABLE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput AL_SIZE_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> AL_ICON_OUT;
        UShortParameter ALIGNMENT;
        UShortParameter LIST_SIZE;
        ushort [] MAPPING;
        private void ICONUPDATE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort H = 0;
            ushort C = 0;
            
            
            __context__.SourceCodeLine = 116;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALIGNMENT  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 118;
                C = (ushort) ( LIST_SIZE  .Value ) ; 
                __context__.SourceCodeLine = 119;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( LIST_SIZE  .Value ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)(I - 1); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 121;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (AL_ICON[ I ] .UshortValue != AL_BLANKICON  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (AL_ENABLE[ I ] .Value == 1) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 123;
                        AL_ICON_OUT [ C]  .Value = (ushort) ( AL_ICON[ I ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 124;
                        MAPPING [ C] = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 125;
                        C = (ushort) ( (C - 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 119;
                    } 
                
                __context__.SourceCodeLine = 129;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)C; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 131;
                    MAPPING [ I] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 132;
                    AL_ICON_OUT [ I]  .Value = (ushort) ( AL_BLANKICON  .UshortValue ) ; 
                    __context__.SourceCodeLine = 129;
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 135;
                C = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 136;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)LIST_SIZE  .Value; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 138;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (AL_ICON[ I ] .UshortValue != AL_BLANKICON  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (AL_ENABLE[ I ] .Value == 1) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 140;
                        AL_ICON_OUT [ C]  .Value = (ushort) ( AL_ICON[ I ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 141;
                        MAPPING [ C] = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 142;
                        C = (ushort) ( (C + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 136;
                    } 
                
                __context__.SourceCodeLine = 146;
                ushort __FN_FORSTART_VAL__4 = (ushort) ( C ) ;
                ushort __FN_FOREND_VAL__4 = (ushort)14; 
                int __FN_FORSTEP_VAL__4 = (int)1; 
                for ( H  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (H  >= __FN_FORSTART_VAL__4) && (H  <= __FN_FOREND_VAL__4) ) : ( (H  <= __FN_FORSTART_VAL__4) && (H  >= __FN_FOREND_VAL__4) ) ; H  += (ushort)__FN_FORSTEP_VAL__4) 
                    { 
                    __context__.SourceCodeLine = 148;
                    MAPPING [ H] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 149;
                    AL_ICON_OUT [ H]  .Value = (ushort) ( AL_BLANKICON  .UshortValue ) ; 
                    __context__.SourceCodeLine = 146;
                    } 
                
                } 
            
            
            }
            
        private void REQUESTUPDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 155;
            CreateWait ( "REQUPDATE" , 20 , REQUPDATE_Callback ) ;
            
            }
            
        public void REQUPDATE_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 157;
            ICONUPDATE (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object AL_SIZE_OnChange_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 166;
            AL_SIZE_OUT  .Value = (ushort) ( AL_SIZE  .UshortValue ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AL_ENABLE_OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 171;
        CancelWait ( "REQUPDATE" ) ; 
        __context__.SourceCodeLine = 172;
        REQUESTUPDATE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AL_PRESS_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        ushort C = 0;
        
        
        __context__.SourceCodeLine = 179;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 181;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AL_ICON_OUT[ I ] .Value != AL_BLANKICON  .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 183;
            C = (ushort) ( MAPPING[ I ] ) ; 
            __context__.SourceCodeLine = 184;
            Functions.Pulse ( 50, AL_PRESS_OUT [ C] ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 198;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)LIST_SIZE  .Value; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 200;
            AL_ENABLE_OUT [ I]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 198;
            } 
        
        __context__.SourceCodeLine = 202;
        AL_SIZE_OUT  .Value = (ushort) ( AL_SIZE  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    MAPPING  = new ushort[ 15 ];
    
    AL_PRESS = new InOutArray<DigitalInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_PRESS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( AL_PRESS__DigitalInput__ + i, AL_PRESS__DigitalInput__, this );
        m_DigitalInputList.Add( AL_PRESS__DigitalInput__ + i, AL_PRESS[i+1] );
    }
    
    AL_ENABLE = new InOutArray<DigitalInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_ENABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( AL_ENABLE__DigitalInput__ + i, AL_ENABLE__DigitalInput__, this );
        m_DigitalInputList.Add( AL_ENABLE__DigitalInput__ + i, AL_ENABLE[i+1] );
    }
    
    AL_PRESS_OUT = new InOutArray<DigitalOutput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_PRESS_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( AL_PRESS_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( AL_PRESS_OUT__DigitalOutput__ + i, AL_PRESS_OUT[i+1] );
    }
    
    AL_ENABLE_OUT = new InOutArray<DigitalOutput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_ENABLE_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( AL_ENABLE_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( AL_ENABLE_OUT__DigitalOutput__ + i, AL_ENABLE_OUT[i+1] );
    }
    
    AL_BLANKICON = new Crestron.Logos.SplusObjects.AnalogInput( AL_BLANKICON__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AL_BLANKICON__AnalogSerialInput__, AL_BLANKICON );
    
    AL_SIZE = new Crestron.Logos.SplusObjects.AnalogInput( AL_SIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AL_SIZE__AnalogSerialInput__, AL_SIZE );
    
    AL_ICON = new InOutArray<AnalogInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_ICON[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( AL_ICON__AnalogSerialInput__ + i, AL_ICON__AnalogSerialInput__, this );
        m_AnalogInputList.Add( AL_ICON__AnalogSerialInput__ + i, AL_ICON[i+1] );
    }
    
    AL_SIZE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( AL_SIZE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AL_SIZE_OUT__AnalogSerialOutput__, AL_SIZE_OUT );
    
    AL_ICON_OUT = new InOutArray<AnalogOutput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        AL_ICON_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( AL_ICON_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( AL_ICON_OUT__AnalogSerialOutput__ + i, AL_ICON_OUT[i+1] );
    }
    
    ALIGNMENT = new UShortParameter( ALIGNMENT__Parameter__, this );
    m_ParameterList.Add( ALIGNMENT__Parameter__, ALIGNMENT );
    
    LIST_SIZE = new UShortParameter( LIST_SIZE__Parameter__, this );
    m_ParameterList.Add( LIST_SIZE__Parameter__, LIST_SIZE );
    
    REQUPDATE_Callback = new WaitFunction( REQUPDATE_CallbackFn );
    
    AL_SIZE.OnAnalogChange.Add( new InputChangeHandlerWrapper( AL_SIZE_OnChange_0, false ) );
    for( uint i = 0; i < 14; i++ )
        AL_ENABLE[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( AL_ENABLE_OnChange_1, false ) );
        
    for( uint i = 0; i < 14; i++ )
        AL_PRESS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( AL_PRESS_OnPush_2, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PG_ACTIONLIST_ICONDRIVER_V1_3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction REQUPDATE_Callback;


const uint AL_PRESS__DigitalInput__ = 0;
const uint AL_ENABLE__DigitalInput__ = 14;
const uint AL_BLANKICON__AnalogSerialInput__ = 0;
const uint AL_SIZE__AnalogSerialInput__ = 1;
const uint AL_ICON__AnalogSerialInput__ = 2;
const uint AL_PRESS_OUT__DigitalOutput__ = 0;
const uint AL_ENABLE_OUT__DigitalOutput__ = 14;
const uint AL_SIZE_OUT__AnalogSerialOutput__ = 0;
const uint AL_ICON_OUT__AnalogSerialOutput__ = 1;
const uint ALIGNMENT__Parameter__ = 10;
const uint LIST_SIZE__Parameter__ = 11;

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
