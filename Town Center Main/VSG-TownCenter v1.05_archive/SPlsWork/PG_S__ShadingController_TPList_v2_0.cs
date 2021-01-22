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
using MD5alt;
using XMLCommunicator;
using CoreHubEvents;
using SS_ShadingController;

namespace UserModule_PG_S__SHADINGCONTROLLER_TPLIST_V2_0
{
    public class UserModuleClass_PG_S__SHADINGCONTROLLER_TPLIST_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput MOVEOPEN;
        Crestron.Logos.SplusObjects.DigitalInput MOVECLOSE;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.DigitalInput SETLEVEL;
        Crestron.Logos.SplusObjects.DigitalInput PRESET1;
        Crestron.Logos.SplusObjects.DigitalInput PRESET2;
        Crestron.Logos.SplusObjects.DigitalInput PRESET3;
        Crestron.Logos.SplusObjects.DigitalInput AREA_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput AREA_OPEN;
        Crestron.Logos.SplusObjects.DigitalInput AREA_CLOSE;
        Crestron.Logos.SplusObjects.DigitalInput AREA_MOVEOPEN;
        Crestron.Logos.SplusObjects.DigitalInput AREA_MOVECLOSE;
        Crestron.Logos.SplusObjects.DigitalInput AREA_SETLEVEL;
        Crestron.Logos.SplusObjects.DigitalInput AREA_PRESET1;
        Crestron.Logos.SplusObjects.DigitalInput AREA_PRESET2;
        Crestron.Logos.SplusObjects.DigitalInput AREA_PRESET3;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LOADTOGGLE;
        Crestron.Logos.SplusObjects.AnalogInput AREAID;
        Crestron.Logos.SplusObjects.AnalogInput LEVELIN;
        Crestron.Logos.SplusObjects.AnalogInput LOADICON_OPEN;
        Crestron.Logos.SplusObjects.AnalogInput LOADICON_CLOSE;
        Crestron.Logos.SplusObjects.StringOutput AREA_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput AREA_OPEN_FB;
        Crestron.Logos.SplusObjects.DigitalOutput AREA_CLOSE_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LOADOPEN_FB;
        Crestron.Logos.SplusObjects.AnalogOutput AREA_LOADLISTSIZE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> LOADICON;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> AREA_LOADNAME;
        SS_ShadingController.ShadingController SC;
        UShortParameter TOUCHPANELID;
        object MOVEOPEN_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 85;
                SC . StartRaise ( ) ; 
                __context__.SourceCodeLine = 85;
                ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object MOVEOPEN_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 89;
            SC . EndRaise ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MOVECLOSE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 93;
        SC . StartLower ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MOVECLOSE_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 97;
        SC . EndLower ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 101;
        SC . SendStop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETLEVEL_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        SC . SetLevel ( (ushort)( LEVELIN  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET1_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 109;
        SC . Preset ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET2_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 113;
        SC . Preset ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET3_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 117;
        SC . Preset ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_TOGGLE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        SC . AreaToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_OPEN_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 126;
        SC . AreaOpen ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_CLOSE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 130;
        SC . AreaClose ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_MOVEOPEN_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 134;
        SC . AreaStartRaise ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_MOVEOPEN_OnRelease_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 138;
        SC . AreaEndRaise ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_MOVECLOSE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        SC . AreaStartLower ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_MOVECLOSE_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 146;
        SC . AreaEndLower ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_SETLEVEL_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        SC . AreaSetLevel ( (ushort)( LEVELIN  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_PRESET1_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 154;
        SC . AreaPreset ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_PRESET2_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 158;
        SC . AreaPreset ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_PRESET3_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        SC . AreaPreset ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOADTOGGLE_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 166;
        SC . ControllerActiveListItem = (int) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 168;
        SC . Toggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREAID_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        SC . ControllerAreaId = (int) ( AREAID  .IntValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void ONUPDATEAREA ( object __sender__ /*SS_ShadingController.ShadingController SC */, SS_ShadingController.SimplPlusDataArgs DA ) 
    { 
    ShadingController  SC  = (ShadingController )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 193;
        AREA_LOADNAME [ DA.sigAnalog]  .UpdateValue ( DA . sigSerial  ) ; 
        __context__.SourceCodeLine = 194;
        AREA_LOADLISTSIZE  .Value = (ushort) ( DA.ConvertToUshort( (int)( DA.flagTag ) ) ) ; 
        __context__.SourceCodeLine = 195;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DA.sigDigital == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 197;
            LOADOPEN_FB [ DA.sigAnalog]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 198;
            LOADICON [ DA.sigAnalog]  .Value = (ushort) ( LOADICON_OPEN  .UshortValue ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 201;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DA.sigDigital == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 203;
                LOADOPEN_FB [ DA.sigAnalog]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 204;
                LOADICON [ DA.sigAnalog]  .Value = (ushort) ( LOADICON_CLOSE  .UshortValue ) ; 
                } 
            
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONUPDATEAREAFEEDBACK ( object __sender__ /*SS_ShadingController.ShadingController SC */, SS_ShadingController.SimplPlusDataArgs DA ) 
    { 
    ShadingController  SC  = (ShadingController )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DA.sigDigital == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            AREA_CLOSE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 212;
            AREA_OPEN_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 214;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DA.sigDigital == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 216;
                AREA_OPEN_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 217;
                AREA_CLOSE_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONUPDATEAREANAME ( object __sender__ /*SS_ShadingController.ShadingController LC */, SS_ShadingController.SimplPlusDataArgs DA ) 
    { 
    ShadingController  LC  = (ShadingController )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 222;
        AREA_NAME  .UpdateValue ( DA . sigSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 231;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 232;
        SC . ControllerListModeActive = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 233;
        SC . TouchpanelID = (ushort) ( TOUCHPANELID  .Value ) ; 
        __context__.SourceCodeLine = 234;
        SC . SetupController ( ) ; 
        __context__.SourceCodeLine = 236;
        // RegisterEvent( SC , UPDATEAREA , ONUPDATEAREA ) 
        try { g_criticalSection.Enter(); SC .updateArea  += ONUPDATEAREA; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 237;
        // RegisterEvent( SC , UPDATEAREAFEEDBACK , ONUPDATEAREAFEEDBACK ) 
        try { g_criticalSection.Enter(); SC .updateAreaFeedback  += ONUPDATEAREAFEEDBACK; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 238;
        // RegisterEvent( SC , UPDATEAREANAME , ONUPDATEAREANAME ) 
        try { g_criticalSection.Enter(); SC .updateAreaName  += ONUPDATEAREANAME; } finally { g_criticalSection.Leave(); }
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    MOVEOPEN = new Crestron.Logos.SplusObjects.DigitalInput( MOVEOPEN__DigitalInput__, this );
    m_DigitalInputList.Add( MOVEOPEN__DigitalInput__, MOVEOPEN );
    
    MOVECLOSE = new Crestron.Logos.SplusObjects.DigitalInput( MOVECLOSE__DigitalInput__, this );
    m_DigitalInputList.Add( MOVECLOSE__DigitalInput__, MOVECLOSE );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    SETLEVEL = new Crestron.Logos.SplusObjects.DigitalInput( SETLEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( SETLEVEL__DigitalInput__, SETLEVEL );
    
    PRESET1 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET1__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET1__DigitalInput__, PRESET1 );
    
    PRESET2 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET2__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET2__DigitalInput__, PRESET2 );
    
    PRESET3 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET3__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET3__DigitalInput__, PRESET3 );
    
    AREA_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( AREA_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_TOGGLE__DigitalInput__, AREA_TOGGLE );
    
    AREA_OPEN = new Crestron.Logos.SplusObjects.DigitalInput( AREA_OPEN__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_OPEN__DigitalInput__, AREA_OPEN );
    
    AREA_CLOSE = new Crestron.Logos.SplusObjects.DigitalInput( AREA_CLOSE__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_CLOSE__DigitalInput__, AREA_CLOSE );
    
    AREA_MOVEOPEN = new Crestron.Logos.SplusObjects.DigitalInput( AREA_MOVEOPEN__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_MOVEOPEN__DigitalInput__, AREA_MOVEOPEN );
    
    AREA_MOVECLOSE = new Crestron.Logos.SplusObjects.DigitalInput( AREA_MOVECLOSE__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_MOVECLOSE__DigitalInput__, AREA_MOVECLOSE );
    
    AREA_SETLEVEL = new Crestron.Logos.SplusObjects.DigitalInput( AREA_SETLEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_SETLEVEL__DigitalInput__, AREA_SETLEVEL );
    
    AREA_PRESET1 = new Crestron.Logos.SplusObjects.DigitalInput( AREA_PRESET1__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_PRESET1__DigitalInput__, AREA_PRESET1 );
    
    AREA_PRESET2 = new Crestron.Logos.SplusObjects.DigitalInput( AREA_PRESET2__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_PRESET2__DigitalInput__, AREA_PRESET2 );
    
    AREA_PRESET3 = new Crestron.Logos.SplusObjects.DigitalInput( AREA_PRESET3__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_PRESET3__DigitalInput__, AREA_PRESET3 );
    
    LOADTOGGLE = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LOADTOGGLE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LOADTOGGLE__DigitalInput__ + i, LOADTOGGLE__DigitalInput__, this );
        m_DigitalInputList.Add( LOADTOGGLE__DigitalInput__ + i, LOADTOGGLE[i+1] );
    }
    
    AREA_OPEN_FB = new Crestron.Logos.SplusObjects.DigitalOutput( AREA_OPEN_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( AREA_OPEN_FB__DigitalOutput__, AREA_OPEN_FB );
    
    AREA_CLOSE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( AREA_CLOSE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( AREA_CLOSE_FB__DigitalOutput__, AREA_CLOSE_FB );
    
    LOADOPEN_FB = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LOADOPEN_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LOADOPEN_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LOADOPEN_FB__DigitalOutput__ + i, LOADOPEN_FB[i+1] );
    }
    
    AREAID = new Crestron.Logos.SplusObjects.AnalogInput( AREAID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AREAID__AnalogSerialInput__, AREAID );
    
    LEVELIN = new Crestron.Logos.SplusObjects.AnalogInput( LEVELIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LEVELIN__AnalogSerialInput__, LEVELIN );
    
    LOADICON_OPEN = new Crestron.Logos.SplusObjects.AnalogInput( LOADICON_OPEN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LOADICON_OPEN__AnalogSerialInput__, LOADICON_OPEN );
    
    LOADICON_CLOSE = new Crestron.Logos.SplusObjects.AnalogInput( LOADICON_CLOSE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LOADICON_CLOSE__AnalogSerialInput__, LOADICON_CLOSE );
    
    AREA_LOADLISTSIZE = new Crestron.Logos.SplusObjects.AnalogOutput( AREA_LOADLISTSIZE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AREA_LOADLISTSIZE__AnalogSerialOutput__, AREA_LOADLISTSIZE );
    
    LOADICON = new InOutArray<AnalogOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LOADICON[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( LOADICON__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( LOADICON__AnalogSerialOutput__ + i, LOADICON[i+1] );
    }
    
    AREA_NAME = new Crestron.Logos.SplusObjects.StringOutput( AREA_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AREA_NAME__AnalogSerialOutput__, AREA_NAME );
    
    AREA_LOADNAME = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        AREA_LOADNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( AREA_LOADNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( AREA_LOADNAME__AnalogSerialOutput__ + i, AREA_LOADNAME[i+1] );
    }
    
    TOUCHPANELID = new UShortParameter( TOUCHPANELID__Parameter__, this );
    m_ParameterList.Add( TOUCHPANELID__Parameter__, TOUCHPANELID );
    
    
    MOVEOPEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MOVEOPEN_OnPush_0, false ) );
    MOVEOPEN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( MOVEOPEN_OnRelease_1, false ) );
    MOVECLOSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MOVECLOSE_OnPush_2, false ) );
    MOVECLOSE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( MOVECLOSE_OnRelease_3, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_4, false ) );
    SETLEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETLEVEL_OnPush_5, false ) );
    PRESET1.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET1_OnPush_6, false ) );
    PRESET2.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET2_OnPush_7, false ) );
    PRESET3.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET3_OnPush_8, false ) );
    AREA_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_TOGGLE_OnPush_9, false ) );
    AREA_OPEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_OPEN_OnPush_10, false ) );
    AREA_CLOSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_CLOSE_OnPush_11, false ) );
    AREA_MOVEOPEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_MOVEOPEN_OnPush_12, false ) );
    AREA_MOVEOPEN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( AREA_MOVEOPEN_OnRelease_13, false ) );
    AREA_MOVECLOSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_MOVECLOSE_OnPush_14, false ) );
    AREA_MOVECLOSE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( AREA_MOVECLOSE_OnRelease_15, false ) );
    AREA_SETLEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_SETLEVEL_OnPush_16, false ) );
    AREA_PRESET1.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_PRESET1_OnPush_17, false ) );
    AREA_PRESET2.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_PRESET2_OnPush_18, false ) );
    AREA_PRESET3.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_PRESET3_OnPush_19, false ) );
    for( uint i = 0; i < 50; i++ )
        LOADTOGGLE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( LOADTOGGLE_OnPush_20, false ) );
        
    AREAID.OnAnalogChange.Add( new InputChangeHandlerWrapper( AREAID_OnChange_21, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SC  = new SS_ShadingController.ShadingController();
    
    
}

public UserModuleClass_PG_S__SHADINGCONTROLLER_TPLIST_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MOVEOPEN__DigitalInput__ = 0;
const uint MOVECLOSE__DigitalInput__ = 1;
const uint STOP__DigitalInput__ = 2;
const uint SETLEVEL__DigitalInput__ = 3;
const uint PRESET1__DigitalInput__ = 4;
const uint PRESET2__DigitalInput__ = 5;
const uint PRESET3__DigitalInput__ = 6;
const uint AREA_TOGGLE__DigitalInput__ = 7;
const uint AREA_OPEN__DigitalInput__ = 8;
const uint AREA_CLOSE__DigitalInput__ = 9;
const uint AREA_MOVEOPEN__DigitalInput__ = 10;
const uint AREA_MOVECLOSE__DigitalInput__ = 11;
const uint AREA_SETLEVEL__DigitalInput__ = 12;
const uint AREA_PRESET1__DigitalInput__ = 13;
const uint AREA_PRESET2__DigitalInput__ = 14;
const uint AREA_PRESET3__DigitalInput__ = 15;
const uint LOADTOGGLE__DigitalInput__ = 16;
const uint AREAID__AnalogSerialInput__ = 0;
const uint LEVELIN__AnalogSerialInput__ = 1;
const uint LOADICON_OPEN__AnalogSerialInput__ = 2;
const uint LOADICON_CLOSE__AnalogSerialInput__ = 3;
const uint AREA_NAME__AnalogSerialOutput__ = 0;
const uint AREA_OPEN_FB__DigitalOutput__ = 0;
const uint AREA_CLOSE_FB__DigitalOutput__ = 1;
const uint LOADOPEN_FB__DigitalOutput__ = 2;
const uint AREA_LOADLISTSIZE__AnalogSerialOutput__ = 1;
const uint LOADICON__AnalogSerialOutput__ = 2;
const uint AREA_LOADNAME__AnalogSerialOutput__ = 52;
const uint TOUCHPANELID__Parameter__ = 10;

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
