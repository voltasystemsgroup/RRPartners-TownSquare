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
using SS_RoviTVListings;

namespace UserModule_PG_S__ROVI_CHAN_FAVS_V4_0
{
    public class UserModuleClass_PG_S__ROVI_CHAN_FAVS_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput KEY_0;
        Crestron.Logos.SplusObjects.DigitalInput KEY_1;
        Crestron.Logos.SplusObjects.DigitalInput KEY_2;
        Crestron.Logos.SplusObjects.DigitalInput KEY_3;
        Crestron.Logos.SplusObjects.DigitalInput KEY_4;
        Crestron.Logos.SplusObjects.DigitalInput KEY_5;
        Crestron.Logos.SplusObjects.DigitalInput KEY_6;
        Crestron.Logos.SplusObjects.DigitalInput KEY_7;
        Crestron.Logos.SplusObjects.DigitalInput KEY_8;
        Crestron.Logos.SplusObjects.DigitalInput KEY_9;
        Crestron.Logos.SplusObjects.DigitalInput KEY_CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput KEY_CANCEL;
        Crestron.Logos.SplusObjects.DigitalInput KEY_ENTER;
        Crestron.Logos.SplusObjects.DigitalInput DEFAULTFAVS;
        Crestron.Logos.SplusObjects.AnalogInput KEYIN__POUND__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> FAVREQ;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_EDITOR_PAGE;
        Crestron.Logos.SplusObjects.AnalogOutput KEYSTATUS__POUND__;
        Crestron.Logos.SplusObjects.StringOutput KEYSTATUS;
        Crestron.Logos.SplusObjects.AnalogOutput FAVOUT;
        Crestron.Logos.SplusObjects.AnalogOutput FAVLISTSIZE__POUND__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> FAVRECALL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CHANNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CHANURL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MLXIMAGE__POUND__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> FAVCHAN__POUND__;
        SS_RoviTVListings.FavCmds FC;
        UShortParameter FAVID;
        StringParameter PROVIDERID;
        InOutArray<UShortParameter> CHANDEFAULTS;
        ushort EDITOR = 0;
        ushort FAVINEDIT = 0;
        CrestronString KEYIN;
        private void SETDEFAULTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 113;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)50; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CHANDEFAULTS[ I ] .Value > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 117;
                    FC . FavsUpdate ( (ushort)( CHANDEFAULTS[ I ] .Value ), (ushort)( I )) ; 
                    } 
                
                __context__.SourceCodeLine = 113;
                } 
            
            
            }
            
        private void KEYUPDATE (  SplusExecutionContext __context__, CrestronString KEY ) 
            { 
            
            __context__.SourceCodeLine = 124;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( KEYIN ) != 4))  ) ) 
                { 
                __context__.SourceCodeLine = 126;
                KEYIN  .UpdateValue ( KEYIN + KEY  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 128;
                KEYIN  .UpdateValue ( "0"  ) ; 
                } 
            
            __context__.SourceCodeLine = 130;
            KEYSTATUS  .UpdateValue ( KEYIN  ) ; 
            __context__.SourceCodeLine = 131;
            KEYSTATUS__POUND__  .Value = (ushort) ( Functions.Atoi( KEYIN ) ) ; 
            
            }
            
        private void RESETALL (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 135;
            EDITOR = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 136;
            SHOW_EDITOR_PAGE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 137;
            FAVINEDIT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 138;
            KEYSTATUS  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 139;
            KEYSTATUS__POUND__  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 140;
            KEYIN  .UpdateValue ( ""  ) ; 
            
            }
            
        private void FREQUEST (  SplusExecutionContext __context__, ushort STATE , ushort INDEX ) 
            { 
            
            __context__.SourceCodeLine = 144;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 146;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDITOR == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 148;
                    RESETALL (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 150;
                FAVINEDIT = (ushort) ( INDEX ) ; 
                __context__.SourceCodeLine = 151;
                CreateWait ( "PANDH" , 250 , PANDH_Callback ) ;
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 160;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDITOR == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 162;
                    CancelWait ( "PANDH" ) ; 
                    __context__.SourceCodeLine = 163;
                    Functions.Pulse ( 010, FAVRECALL [ INDEX] ) ; 
                    __context__.SourceCodeLine = 164;
                    FAVOUT  .Value = (ushort) ( FC.GetChanNum( (ushort)( INDEX ) ) ) ; 
                    } 
                
                } 
            
            
            }
            
        public void PANDH_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 152;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDITOR == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 154;
                EDITOR = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 155;
                SHOW_EDITOR_PAGE  .Value = (ushort) ( 1 ) ; 
                } 
            
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object DEFAULTFAVS_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 171;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FC.UpdaterConnected == 1))  ) ) 
                {
                __context__.SourceCodeLine = 172;
                SETDEFAULTS (  __context__  ) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEYIN__POUND___OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FC.UpdaterConnected == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( FAVINEDIT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (EDITOR == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                KEYIN  .UpdateValue ( Functions.ItoA (  (int) ( KEYIN__POUND__  .UshortValue ) )  ) ; 
                __context__.SourceCodeLine = 182;
                KEYSTATUS  .UpdateValue ( Functions.ItoA (  (int) ( KEYIN__POUND__  .UshortValue ) )  ) ; 
                __context__.SourceCodeLine = 183;
                KEYSTATUS__POUND__  .Value = (ushort) ( KEYIN__POUND__  .UshortValue ) ; 
                __context__.SourceCodeLine = 185;
                FC . FavsUpdate ( (ushort)( Functions.Atoi( KEYIN ) ), (ushort)( FAVINEDIT )) ; 
                __context__.SourceCodeLine = 186;
                RESETALL (  __context__  ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 189;
            /* Trace( "[{0:d}]Not attatched to fav... no update possible", (short)FAVID  .Value) */ ; 
            __context__.SourceCodeLine = 190;
            RESETALL (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVREQ_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 196;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 197;
        CancelWait ( "PANDH" ) ; 
        __context__.SourceCodeLine = 198;
        FREQUEST (  __context__ , (ushort)( 0 ), (ushort)( I )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVREQ_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 203;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 204;
        FREQUEST (  __context__ , (ushort)( 1 ), (ushort)( I )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_ENTER_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 208;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( KEYIN ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 210;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FC.UpdaterConnected == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 213;
                FC . FavsUpdate ( (ushort)( Functions.Atoi( KEYIN ) ), (ushort)( FAVINEDIT )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 215;
                /* Trace( "[{0:d}]Not attatched to fav... no update possible", (short)FAVID  .Value) */ ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 218;
        RESETALL (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_CANCEL_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 223;
        RESETALL (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_CLEAR_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 228;
        KEYSTATUS  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 229;
        KEYSTATUS__POUND__  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 230;
        KEYIN  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_0_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 234;
        KEYUPDATE (  __context__ , "0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_1_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 238;
        KEYUPDATE (  __context__ , "1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_2_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 242;
        KEYUPDATE (  __context__ , "2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_3_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 246;
        KEYUPDATE (  __context__ , "3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_4_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 250;
        KEYUPDATE (  __context__ , "4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_5_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 254;
        KEYUPDATE (  __context__ , "5") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_6_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 258;
        KEYUPDATE (  __context__ , "6") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_7_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 262;
        KEYUPDATE (  __context__ , "7") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_8_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 266;
        KEYUPDATE (  __context__ , "8") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_9_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 270;
        KEYUPDATE (  __context__ , "9") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void ONDEFAULTREQUEST ( object __sender__ /*SS_RoviTVListings.FavCmds F */, EventArgs E ) 
    { 
    FavCmds  F  = (FavCmds )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 274;
        SETDEFAULTS (  __context__  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONFAVCHANGED ( object __sender__ /*SS_RoviTVListings.FavCmds F */, SS_RoviTVListings.FavChangeEventArgs FAVARGS ) 
    { 
    FavCmds  F  = (FavCmds )__sender__;
    ushort I = 0;
    ushort NUM = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 280;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FAVARGS.ChanIndex > FAVLISTSIZE__POUND__  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 282;
            FAVLISTSIZE__POUND__  .Value = (ushort) ( FAVARGS.ChanIndex ) ; 
            } 
        
        __context__.SourceCodeLine = 285;
        FAVCHAN__POUND__ [ FAVARGS.ChanIndex]  .Value = (ushort) ( Functions.Atoi( FAVARGS.ChanNum ) ) ; 
        __context__.SourceCodeLine = 286;
        CHANNAME [ FAVARGS.ChanIndex]  .UpdateValue ( FAVARGS . ChanName  ) ; 
        __context__.SourceCodeLine = 287;
        CHANURL [ FAVARGS.ChanIndex]  .UpdateValue ( FAVARGS . ChanURL  ) ; 
        __context__.SourceCodeLine = 288;
        MLXIMAGE__POUND__ [ FAVARGS.ChanIndex]  .Value = (ushort) ( FAVARGS.MLXImageID ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 299;
        FAVLISTSIZE__POUND__  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 300;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 301;
        FC . SetFavID ( Functions.ItoA( (int)( FAVID  .Value ) ) .ToString()) ; 
        __context__.SourceCodeLine = 302;
        // RegisterEvent( FC , UPDATEFAV , ONFAVCHANGED ) 
        try { g_criticalSection.Enter(); FC .updateFav  += ONFAVCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 303;
        // RegisterEvent( FC , DEFAULTFAVSREQ , ONDEFAULTREQUEST ) 
        try { g_criticalSection.Enter(); FC .defaultFavsReq  += ONDEFAULTREQUEST; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 304;
        FC . SetProviderID ( PROVIDERID  .ToString()) ; 
        __context__.SourceCodeLine = 305;
        RESETALL (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    KEYIN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    
    KEY_0 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_0__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_0__DigitalInput__, KEY_0 );
    
    KEY_1 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_1__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_1__DigitalInput__, KEY_1 );
    
    KEY_2 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_2__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_2__DigitalInput__, KEY_2 );
    
    KEY_3 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_3__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_3__DigitalInput__, KEY_3 );
    
    KEY_4 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_4__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_4__DigitalInput__, KEY_4 );
    
    KEY_5 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_5__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_5__DigitalInput__, KEY_5 );
    
    KEY_6 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_6__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_6__DigitalInput__, KEY_6 );
    
    KEY_7 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_7__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_7__DigitalInput__, KEY_7 );
    
    KEY_8 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_8__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_8__DigitalInput__, KEY_8 );
    
    KEY_9 = new Crestron.Logos.SplusObjects.DigitalInput( KEY_9__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_9__DigitalInput__, KEY_9 );
    
    KEY_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KEY_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_CLEAR__DigitalInput__, KEY_CLEAR );
    
    KEY_CANCEL = new Crestron.Logos.SplusObjects.DigitalInput( KEY_CANCEL__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_CANCEL__DigitalInput__, KEY_CANCEL );
    
    KEY_ENTER = new Crestron.Logos.SplusObjects.DigitalInput( KEY_ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_ENTER__DigitalInput__, KEY_ENTER );
    
    DEFAULTFAVS = new Crestron.Logos.SplusObjects.DigitalInput( DEFAULTFAVS__DigitalInput__, this );
    m_DigitalInputList.Add( DEFAULTFAVS__DigitalInput__, DEFAULTFAVS );
    
    FAVREQ = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        FAVREQ[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( FAVREQ__DigitalInput__ + i, FAVREQ__DigitalInput__, this );
        m_DigitalInputList.Add( FAVREQ__DigitalInput__ + i, FAVREQ[i+1] );
    }
    
    SHOW_EDITOR_PAGE = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_EDITOR_PAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_EDITOR_PAGE__DigitalOutput__, SHOW_EDITOR_PAGE );
    
    FAVRECALL = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        FAVRECALL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( FAVRECALL__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( FAVRECALL__DigitalOutput__ + i, FAVRECALL[i+1] );
    }
    
    KEYIN__POUND__ = new Crestron.Logos.SplusObjects.AnalogInput( KEYIN__POUND____AnalogSerialInput__, this );
    m_AnalogInputList.Add( KEYIN__POUND____AnalogSerialInput__, KEYIN__POUND__ );
    
    KEYSTATUS__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( KEYSTATUS__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( KEYSTATUS__POUND____AnalogSerialOutput__, KEYSTATUS__POUND__ );
    
    FAVOUT = new Crestron.Logos.SplusObjects.AnalogOutput( FAVOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FAVOUT__AnalogSerialOutput__, FAVOUT );
    
    FAVLISTSIZE__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( FAVLISTSIZE__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FAVLISTSIZE__POUND____AnalogSerialOutput__, FAVLISTSIZE__POUND__ );
    
    MLXIMAGE__POUND__ = new InOutArray<AnalogOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        MLXIMAGE__POUND__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MLXIMAGE__POUND____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MLXIMAGE__POUND____AnalogSerialOutput__ + i, MLXIMAGE__POUND__[i+1] );
    }
    
    FAVCHAN__POUND__ = new InOutArray<AnalogOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        FAVCHAN__POUND__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( FAVCHAN__POUND____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( FAVCHAN__POUND____AnalogSerialOutput__ + i, FAVCHAN__POUND__[i+1] );
    }
    
    KEYSTATUS = new Crestron.Logos.SplusObjects.StringOutput( KEYSTATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( KEYSTATUS__AnalogSerialOutput__, KEYSTATUS );
    
    CHANNAME = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CHANNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CHANNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CHANNAME__AnalogSerialOutput__ + i, CHANNAME[i+1] );
    }
    
    CHANURL = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CHANURL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CHANURL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CHANURL__AnalogSerialOutput__ + i, CHANURL[i+1] );
    }
    
    FAVID = new UShortParameter( FAVID__Parameter__, this );
    m_ParameterList.Add( FAVID__Parameter__, FAVID );
    
    CHANDEFAULTS = new InOutArray<UShortParameter>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CHANDEFAULTS[i+1] = new UShortParameter( CHANDEFAULTS__Parameter__ + i, CHANDEFAULTS__Parameter__, this );
        m_ParameterList.Add( CHANDEFAULTS__Parameter__ + i, CHANDEFAULTS[i+1] );
    }
    
    PROVIDERID = new StringParameter( PROVIDERID__Parameter__, this );
    m_ParameterList.Add( PROVIDERID__Parameter__, PROVIDERID );
    
    PANDH_Callback = new WaitFunction( PANDH_CallbackFn );
    
    DEFAULTFAVS.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEFAULTFAVS_OnPush_0, false ) );
    KEYIN__POUND__.OnAnalogChange.Add( new InputChangeHandlerWrapper( KEYIN__POUND___OnChange_1, false ) );
    for( uint i = 0; i < 50; i++ )
        FAVREQ[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( FAVREQ_OnPush_2, false ) );
        
    for( uint i = 0; i < 50; i++ )
        FAVREQ[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( FAVREQ_OnRelease_3, false ) );
        
    KEY_ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_ENTER_OnPush_4, false ) );
    KEY_CANCEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_CANCEL_OnPush_5, false ) );
    KEY_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_CLEAR_OnPush_6, false ) );
    KEY_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_0_OnPush_7, false ) );
    KEY_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_1_OnPush_8, false ) );
    KEY_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_2_OnPush_9, false ) );
    KEY_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_3_OnPush_10, false ) );
    KEY_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_4_OnPush_11, false ) );
    KEY_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_5_OnPush_12, false ) );
    KEY_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_6_OnPush_13, false ) );
    KEY_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_7_OnPush_14, false ) );
    KEY_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_8_OnPush_15, false ) );
    KEY_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_9_OnPush_16, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    FC  = new SS_RoviTVListings.FavCmds();
    
    
}

public UserModuleClass_PG_S__ROVI_CHAN_FAVS_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction PANDH_Callback;


const uint KEY_0__DigitalInput__ = 0;
const uint KEY_1__DigitalInput__ = 1;
const uint KEY_2__DigitalInput__ = 2;
const uint KEY_3__DigitalInput__ = 3;
const uint KEY_4__DigitalInput__ = 4;
const uint KEY_5__DigitalInput__ = 5;
const uint KEY_6__DigitalInput__ = 6;
const uint KEY_7__DigitalInput__ = 7;
const uint KEY_8__DigitalInput__ = 8;
const uint KEY_9__DigitalInput__ = 9;
const uint KEY_CLEAR__DigitalInput__ = 10;
const uint KEY_CANCEL__DigitalInput__ = 11;
const uint KEY_ENTER__DigitalInput__ = 12;
const uint DEFAULTFAVS__DigitalInput__ = 13;
const uint KEYIN__POUND____AnalogSerialInput__ = 0;
const uint FAVREQ__DigitalInput__ = 14;
const uint SHOW_EDITOR_PAGE__DigitalOutput__ = 0;
const uint KEYSTATUS__POUND____AnalogSerialOutput__ = 0;
const uint KEYSTATUS__AnalogSerialOutput__ = 1;
const uint FAVOUT__AnalogSerialOutput__ = 2;
const uint FAVLISTSIZE__POUND____AnalogSerialOutput__ = 3;
const uint FAVRECALL__DigitalOutput__ = 1;
const uint CHANNAME__AnalogSerialOutput__ = 4;
const uint CHANURL__AnalogSerialOutput__ = 54;
const uint MLXIMAGE__POUND____AnalogSerialOutput__ = 104;
const uint FAVCHAN__POUND____AnalogSerialOutput__ = 154;
const uint FAVID__Parameter__ = 10;
const uint PROVIDERID__Parameter__ = 11;
const uint CHANDEFAULTS__Parameter__ = 12;

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
