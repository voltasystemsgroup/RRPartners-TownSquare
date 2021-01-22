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

namespace CrestronModule_TSTATEX_SCHEDULER__5_2_PROGRAM__V1_0
{
    public class CrestronModuleClass_TSTATEX_SCHEDULER__5_2_PROGRAM__V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_WAKE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_LEAVE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_RETURN;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_SLEEP;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_WAKE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_LEAVE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_RETURN;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_SLEEP;
        Crestron.Logos.SplusObjects.DigitalInput AWAY;
        Crestron.Logos.SplusObjects.DigitalInput TIME_UP;
        Crestron.Logos.SplusObjects.DigitalInput TIME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_UP;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_UP;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput REMOVE_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput RESET_SCHEDULES;
        Crestron.Logos.SplusObjects.DigitalInput HALF_DEGREE_C_STEPS;
        Crestron.Logos.SplusObjects.DigitalInput RUN_PROGRAM;
        Crestron.Logos.SplusObjects.DigitalInput RUN_AWAY;
        Crestron.Logos.SplusObjects.DigitalInput RUN_HOLD;
        Crestron.Logos.SplusObjects.DigitalInput USE_DEFAULT_SCHEDULE_TIMES;
        Crestron.Logos.SplusObjects.DigitalInput SUNDAY_NIGHT_IS_WEEKDAY;
        Crestron.Logos.SplusObjects.DigitalInput FRIDAY_NIGHT_IS_WEEKEND;
        Crestron.Logos.SplusObjects.DigitalInput AWAYDAY_INC;
        Crestron.Logos.SplusObjects.DigitalInput AWAYDAY_DEC;
        Crestron.Logos.SplusObjects.DigitalInput AWAYSCHED_INC;
        Crestron.Logos.SplusObjects.DigitalInput HEATMODE;
        Crestron.Logos.SplusObjects.DigitalInput COOLMODE;
        Crestron.Logos.SplusObjects.DigitalInput SINGLEAUTOMODE;
        Crestron.Logos.SplusObjects.DigitalInput DUALAUTOMODE;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_HEAT_SP;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_COOL_SP;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_AUTO_SP;
        Crestron.Logos.SplusObjects.AnalogInput INSTANCE_ID;
        Crestron.Logos.SplusObjects.AnalogInput AI_MAX_HEAT_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput AI_MIN_HEAT_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput AI_MAX_COOL_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput AI_MIN_COOL_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput AI_MIN_SINGLEAUTO_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput AI_MAX_SINGLEAUTO_SETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput DIRECTSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDHEATSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDCOOLSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDAUTO1PTSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput DEADBAND;
        Crestron.Logos.SplusObjects.StringInput PATH__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> CURRENTSETPOINT;
        Crestron.Logos.SplusObjects.DigitalOutput SCHEDULE_DUE;
        Crestron.Logos.SplusObjects.DigitalOutput PM_FB;
        Crestron.Logos.SplusObjects.DigitalOutput TEMP_SCALE_ERR;
        Crestron.Logos.SplusObjects.DigitalOutput RUN;
        Crestron.Logos.SplusObjects.DigitalOutput AWAY_MODE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput HOLD_MODE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_SCHEDULE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_DAYOFWEEK;
        Crestron.Logos.SplusObjects.AnalogOutput RUNSCHEDULE;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_SCHEDULE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_SCHEDULE_SHORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_DATE_SHORT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> REVISEDSETPOINT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SCHEDULE_SETPOINT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SETPOINT;
        SCHEDULE [] G_SCHED;
        uint G_TODAYJDAY = 0;
        short MAXHEATSETPOINT = 0;
        short MINHEATSETPOINT = 0;
        short MAXCOOLSETPOINT = 0;
        short MINCOOLSETPOINT = 0;
        short MAXAUTOSETPOINT = 0;
        short MINAUTOSETPOINT = 0;
        short SETPOINTTEMPORARY = 0;
        ushort TEMP_SCALE = 0;
        ushort G_IRUNSCHEDULE = 0;
        private uint CREATEDATEL (  SplusExecutionContext __context__, ushort IMONTH , ushort IDAY , ushort IYEAR ) 
            { 
            
            __context__.SourceCodeLine = 270;
            return (uint)( (((IMONTH * 1000000) + (IDAY * 10000)) + IYEAR)) ; 
            
            }
            
        private ushort GETDAYFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 276;
            return (ushort)( (Mod( LDATE , 1000000 ) / 10000)) ; 
            
            }
            
        private ushort GETMONTHFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 282;
            return (ushort)( (LDATE / 1000000)) ; 
            
            }
            
        private ushort GETYEARFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 288;
            return (ushort)( Mod( LDATE , 10000 )) ; 
            
            }
            
        private uint GETJDAY (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort PRVYEAR = 0;
            
            ushort LEAPYEAR = 0;
            
            ushort TEMPYEAR = 0;
            
            ushort TEMPMONTH = 0;
            
            ushort TEMPDAY = 0;
            
            ushort JDAY = 0;
            
            ushort LEAPS = 0;
            
            
            __context__.SourceCodeLine = 303;
            TEMPDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 304;
            TEMPMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 305;
            TEMPYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 308;
            PRVYEAR = (ushort) ( (TEMPYEAR - 1) ) ; 
            __context__.SourceCodeLine = 309;
            LEAPS = (ushort) ( ((((PRVYEAR / 4) - (PRVYEAR / 100)) + (PRVYEAR / 400)) - 484) ) ; 
            __context__.SourceCodeLine = 312;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 313;
                LEAPYEAR = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 315;
                LEAPYEAR = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 317;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)TEMPMONTH);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 320;
                        JDAY = (ushort) ( TEMPDAY ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 322;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , (28 + LEAPYEAR) ) ) ; 
                        __context__.SourceCodeLine = 323;
                        JDAY = (ushort) ( (TEMPDAY + 31) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 326;
                        JDAY = (ushort) ( (TEMPDAY + 59) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 328;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 329;
                        JDAY = (ushort) ( (TEMPDAY + 90) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 332;
                        JDAY = (ushort) ( (TEMPDAY + 120) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 334;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 335;
                        JDAY = (ushort) ( (TEMPDAY + 151) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 338;
                        JDAY = (ushort) ( (TEMPDAY + 181) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 340;
                        JDAY = (ushort) ( (TEMPDAY + 212) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 342;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 343;
                        JDAY = (ushort) ( (TEMPDAY + 243) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 346;
                        JDAY = (ushort) ( (TEMPDAY + 273) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 348;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 349;
                        JDAY = (ushort) ( (TEMPDAY + 304) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 352;
                        JDAY = (ushort) ( (TEMPDAY + 334) ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 355;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEAPYEAR == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 2) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 356;
                JDAY = (ushort) ( (JDAY + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 358;
            JDAY = (ushort) ( ((JDAY + ((PRVYEAR - 1996) * 365)) + LEAPS) ) ; 
            __context__.SourceCodeLine = 360;
            return (uint)( JDAY) ; 
            
            }
            
        private uint GETGDATE (  SplusExecutionContext __context__, uint JDAY ) 
            { 
            uint TEMPDAY = 0;
            
            uint TEMPMONTH = 0;
            
            uint TEMPYEAR = 0;
            
            uint REMCENTS = 0;
            
            uint REMQUADS = 0;
            
            uint REMYEARS = 0;
            
            uint LEAPYEAR = 0;
            
            
            __context__.SourceCodeLine = 377;
            TEMPMONTH = (uint) ( 0 ) ; 
            __context__.SourceCodeLine = 379;
            REMCENTS = (uint) ( (JDAY / 36524) ) ; 
            __context__.SourceCodeLine = 380;
            JDAY = (uint) ( (JDAY - (36524 * REMCENTS)) ) ; 
            __context__.SourceCodeLine = 381;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 382;
                TEMPYEAR = (uint) ( (1996 + (100 * REMCENTS)) ) ; 
                __context__.SourceCodeLine = 383;
                TEMPDAY = (uint) ( 365 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 386;
                REMQUADS = (uint) ( (JDAY / 1461) ) ; 
                __context__.SourceCodeLine = 387;
                JDAY = (uint) ( (JDAY - (1461 * REMQUADS)) ) ; 
                __context__.SourceCodeLine = 388;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 389;
                    TEMPYEAR = (uint) ( ((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) ) ; 
                    __context__.SourceCodeLine = 390;
                    TEMPDAY = (uint) ( (365 + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 393;
                    REMYEARS = (uint) ( (JDAY / 365) ) ; 
                    __context__.SourceCodeLine = 394;
                    JDAY = (uint) ( (JDAY - (365 * REMYEARS)) ) ; 
                    __context__.SourceCodeLine = 395;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 396;
                        TEMPYEAR = (uint) ( (((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 398;
                        TEMPDAY = (uint) ( 365 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 401;
                        TEMPYEAR = (uint) ( ((((1 + 1996) + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 403;
                        TEMPDAY = (uint) ( JDAY ) ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 410;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 411;
                LEAPYEAR = (uint) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 413;
                LEAPYEAR = (uint) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 415;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 417;
                TEMPMONTH = (uint) ( 12 ) ; 
                __context__.SourceCodeLine = 418;
                TEMPDAY = (uint) ( 31 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 420;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= 31 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 422;
                    TEMPMONTH = (uint) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 424;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 59) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 426;
                        TEMPMONTH = (uint) ( 2 ) ; 
                        __context__.SourceCodeLine = 427;
                        TEMPDAY = (uint) ( (TEMPDAY - 31) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 429;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 90) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 431;
                            TEMPMONTH = (uint) ( 3 ) ; 
                            __context__.SourceCodeLine = 432;
                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 59) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 434;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 120) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 436;
                                TEMPMONTH = (uint) ( 4 ) ; 
                                __context__.SourceCodeLine = 437;
                                TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 90) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 439;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 151) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 441;
                                    TEMPMONTH = (uint) ( 5 ) ; 
                                    __context__.SourceCodeLine = 442;
                                    TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 120) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 444;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 181) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 446;
                                        TEMPMONTH = (uint) ( 6 ) ; 
                                        __context__.SourceCodeLine = 447;
                                        TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 151) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 449;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 212) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 451;
                                            TEMPMONTH = (uint) ( 7 ) ; 
                                            __context__.SourceCodeLine = 452;
                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 181) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 454;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 243) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 456;
                                                TEMPMONTH = (uint) ( 8 ) ; 
                                                __context__.SourceCodeLine = 457;
                                                TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 212) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 459;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 273) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 461;
                                                    TEMPMONTH = (uint) ( 9 ) ; 
                                                    __context__.SourceCodeLine = 462;
                                                    TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 243) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 464;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 304) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 466;
                                                        TEMPMONTH = (uint) ( 10 ) ; 
                                                        __context__.SourceCodeLine = 467;
                                                        TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 273) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 469;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 334) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 471;
                                                            TEMPMONTH = (uint) ( 11 ) ; 
                                                            __context__.SourceCodeLine = 472;
                                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 304) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 476;
                                                            TEMPMONTH = (uint) ( 12 ) ; 
                                                            __context__.SourceCodeLine = 477;
                                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 334) ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 480;
            return (uint)( CREATEDATEL( __context__ , (ushort)( TEMPMONTH ) , (ushort)( TEMPDAY ) , (ushort)( TEMPYEAR ) )) ; 
            
            }
            
        private CrestronString GETFILENAME (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SFILENAME;
            SFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 488;
            SFILENAME  .UpdateValue ( PATH__DOLLAR__ + "tstat_" + Functions.ItoA (  (int) ( INSTANCE_ID  .UshortValue ) ) + ".dat"  ) ; 
            __context__.SourceCodeLine = 490;
            return ( SFILENAME ) ; 
            
            }
            
        private short ROUNDEDDIVIDE (  SplusExecutionContext __context__, short IOPERAND , short IDIVISOR ) 
            { 
            short IQUOTIENT = 0;
            short IREMAINDER = 0;
            
            
            __context__.SourceCodeLine = 512;
            IQUOTIENT = (short) ( (IOPERAND / IDIVISOR) ) ; 
            __context__.SourceCodeLine = 513;
            IREMAINDER = (short) ( Mod( IOPERAND , IDIVISOR ) ) ; 
            __context__.SourceCodeLine = 515;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREMAINDER < (IDIVISOR / 2) ))  ) ) 
                {
                __context__.SourceCodeLine = 516;
                return (short)( IQUOTIENT) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 518;
                return (short)( (IQUOTIENT + 1)) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private short GETRAWTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort ISCALEDTEMP ) 
            { 
            
            __context__.SourceCodeLine = 538;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 540;
                return (short)( ROUNDEDDIVIDE( __context__ , (short)( ((ISCALEDTEMP - 320) * 5) ) , (short)( 9 ) )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 543;
                return (short)( ISCALEDTEMP) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETSCALEDTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort IRAWTEMP ) 
            { 
            ushort ISCALEDTEMP = 0;
            
            
            __context__.SourceCodeLine = 566;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 568;
                if ( Functions.TestForTrue  ( ( HALF_DEGREE_C_STEPS  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 569;
                    return (ushort)( (ROUNDEDDIVIDE( __context__ , (short)( IRAWTEMP ) , (short)( 5 ) ) * 5)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 571;
                    return (ushort)( (ROUNDEDDIVIDE( __context__ , (short)( IRAWTEMP ) , (short)( 10 ) ) * 10)) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 575;
                ISCALEDTEMP = (ushort) ( (ROUNDEDDIVIDE( __context__ , (short)( (IRAWTEMP * 9) ) , (short)( 5 ) ) + 320) ) ; 
                __context__.SourceCodeLine = 576;
                return (ushort)( (ROUNDEDDIVIDE( __context__ , (short)( ISCALEDTEMP ) , (short)( 10 ) ) * 10)) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString GETDISPLAYTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort IRAWTEMP ) 
            { 
            short ISCALEDTEMP = 0;
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            ushort IINTPART = 0;
            ushort IFRACPART = 0;
            
            
            __context__.SourceCodeLine = 620;
            ISCALEDTEMP = (short) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( IRAWTEMP ) ) ) ; 
            __context__.SourceCodeLine = 622;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITEMPSCALE == 0) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITEMPSCALE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (HALF_DEGREE_C_STEPS  .Value == 0) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 624;
                return ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( ISCALEDTEMP ) , (short)( 10 ) ) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 629;
                IINTPART = (ushort) ( (ISCALEDTEMP / 10) ) ; 
                __context__.SourceCodeLine = 630;
                IFRACPART = (ushort) ( Mod( ISCALEDTEMP , 10 ) ) ; 
                __context__.SourceCodeLine = 632;
                if ( Functions.TestForTrue  ( ( IFRACPART)  ) ) 
                    {
                    __context__.SourceCodeLine = 633;
                    STEMP  .UpdateValue ( Functions.ItoA (  (int) ( IINTPART ) ) + "." + Functions.ItoA (  (int) ( IFRACPART ) )  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 635;
                    STEMP  .UpdateValue ( Functions.ItoA (  (int) ( IINTPART ) ) + ".0"  ) ; 
                    }
                
                __context__.SourceCodeLine = 637;
                return ( STEMP ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private ushort ADJUSTTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , short IRAWTEMP , ushort IDIR , short IMINRAWTEMP , short IMAXRAWTEMP ) 
            { 
            short IADJUSTEDRAWTEMP = 0;
            
            ushort ITEMPINDEGF = 0;
            
            ushort IADJUST = 0;
            
            
            __context__.SourceCodeLine = 663;
            
            __context__.SourceCodeLine = 667;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 671;
                ITEMPINDEGF = (ushort) ( ROUNDEDDIVIDE( __context__ , (short)( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( IRAWTEMP ) ) ) , (short)( 10 ) ) ) ; 
                __context__.SourceCodeLine = 673;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 674;
                    ITEMPINDEGF = (ushort) ( (ITEMPINDEGF + 1) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 675;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 676;
                        ITEMPINDEGF = (ushort) ( (ITEMPINDEGF - 1) ) ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 678;
                IADJUSTEDRAWTEMP = (short) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( (ITEMPINDEGF * 10) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 683;
                if ( Functions.TestForTrue  ( ( HALF_DEGREE_C_STEPS  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 684;
                    IADJUST = (ushort) ( 5 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 686;
                    IADJUST = (ushort) ( 10 ) ; 
                    }
                
                __context__.SourceCodeLine = 688;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 689;
                    IADJUSTEDRAWTEMP = (short) ( (IRAWTEMP + IADJUST) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 690;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 691;
                        IADJUSTEDRAWTEMP = (short) ( (IRAWTEMP - IADJUST) ) ; 
                        }
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 695;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IADJUSTEDRAWTEMP > IMAXRAWTEMP ))  ) ) 
                {
                __context__.SourceCodeLine = 696;
                return (ushort)( IMAXRAWTEMP) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 697;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IADJUSTEDRAWTEMP < IMINRAWTEMP ))  ) ) 
                    {
                    __context__.SourceCodeLine = 698;
                    return (ushort)( IMINRAWTEMP) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 700;
                    return (ushort)( IADJUSTEDRAWTEMP) ; 
                    }
                
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString GETDISPLAYTIME (  SplusExecutionContext __context__, short IHOUR , ushort IMINUTE ) 
            { 
            ushort IDISPLAYHOUR = 0;
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 718;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == -1))  ) ) 
                { 
                __context__.SourceCodeLine = 720;
                return ( "--:--" ) ; 
                } 
            
            __context__.SourceCodeLine = 723;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR > 23 ))  ) ) 
                {
                __context__.SourceCodeLine = 724;
                IHOUR = (short) ( (IHOUR - 24) ) ; 
                }
            
            __context__.SourceCodeLine = 726;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IHOUR , 12 ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 727;
                IDISPLAYHOUR = (ushort) ( 12 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 729;
                IDISPLAYHOUR = (ushort) ( Mod( IHOUR , 12 ) ) ; 
                }
            
            __context__.SourceCodeLine = 731;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 12 ))  ) ) 
                {
                __context__.SourceCodeLine = 732;
                MakeString ( STIME , "{0,2:d}:{1:d2} AM", (short)IDISPLAYHOUR, (short)IMINUTE) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 734;
                MakeString ( STIME , "{0,2:d}:{1:d2} PM", (short)IDISPLAYHOUR, (short)IMINUTE) ; 
                }
            
            __context__.SourceCodeLine = 736;
            return ( STIME ) ; 
            
            }
            
        
        private ushort GETAUTOSETPOINT (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort ISCHEDULE ) 
            { 
            ushort IQUOTIENT = 0;
            ushort IREMAINDER = 0;
            ushort IHEAT = 0;
            ushort ICOOL = 0;
            
            
            __context__.SourceCodeLine = 758;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
                { 
                __context__.SourceCodeLine = 760;
                IHEAT = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( G_SCHED[ ISCHEDULE ].ISETPOINT[ 0 ] ) ) ) ; 
                __context__.SourceCodeLine = 761;
                ICOOL = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( G_SCHED[ ISCHEDULE ].ISETPOINT[ 1 ] ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 765;
                IHEAT = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( 212 ) ) ) ; 
                __context__.SourceCodeLine = 766;
                ICOOL = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( 234 ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 769;
            IQUOTIENT = (ushort) ( ((IHEAT + ICOOL) / 20) ) ; 
            __context__.SourceCodeLine = 770;
            IREMAINDER = (ushort) ( Mod( (IHEAT + ICOOL) , 20 ) ) ; 
            __context__.SourceCodeLine = 772;
            
            __context__.SourceCodeLine = 777;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREMAINDER < 10 ))  ) ) 
                {
                __context__.SourceCodeLine = 778;
                return (ushort)( (IQUOTIENT * 10)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 780;
                return (ushort)( ((IQUOTIENT + 1) * 10)) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void UPDATECURRENTSCHEDULESETPOINTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 798;
            
            __context__.SourceCodeLine = 803;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
                { 
                __context__.SourceCodeLine = 805;
                SETPOINT [ (0 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ].ISETPOINT[ 0 ] ) ) ) ; 
                __context__.SourceCodeLine = 806;
                SETPOINT [ (1 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ].ISETPOINT[ 1 ] ) ) ) ; 
                __context__.SourceCodeLine = 808;
                
                __context__.SourceCodeLine = 812;
                SETPOINT [ (2 + 1)]  .Value = (ushort) ( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_ICURRENTSCHEDULE ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 817;
                SETPOINT [ (0 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( 212 ) ) ) ; 
                __context__.SourceCodeLine = 818;
                SETPOINT [ (1 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( 234 ) ) ) ; 
                __context__.SourceCodeLine = 820;
                
                __context__.SourceCodeLine = 824;
                SETPOINT [ (2 + 1)]  .Value = (ushort) ( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_ICURRENTSCHEDULE ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 828;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
                { 
                __context__.SourceCodeLine = 830;
                G_IRUNSCHEDULE = (ushort) ( (Mod( (G_IRUNSCHEDULE + 1) , 65535 ) + 1) ) ; 
                __context__.SourceCodeLine = 831;
                RUNSCHEDULE  .Value = (ushort) ( G_IRUNSCHEDULE ) ; 
                } 
            
            
            }
            
        private void UPDATEAWAYMESSAGE (  SplusExecutionContext __context__ ) 
            { 
            CrestronString MNTH;
            MNTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
            
            CrestronString MNTH_SHORT;
            MNTH_SHORT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            ushort MN = 0;
            ushort DY = 0;
            ushort YR = 0;
            
            uint TEMP = 0;
            
            
            __context__.SourceCodeLine = 855;
            TEMP = (uint) ( GETGDATE( __context__ , (uint)( _SplusNVRAM.G_LTARGETJDAY ) ) ) ; 
            __context__.SourceCodeLine = 857;
            MN = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 858;
            DY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 859;
            YR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 861;
            switch ((int)MN)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 863;
                    MNTH  .UpdateValue ( "January"  ) ; 
                    __context__.SourceCodeLine = 864;
                    MNTH_SHORT  .UpdateValue ( "Jan."  ) ; 
                    __context__.SourceCodeLine = 865;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 866;
                    MNTH  .UpdateValue ( "February"  ) ; 
                    __context__.SourceCodeLine = 867;
                    MNTH_SHORT  .UpdateValue ( "Feb."  ) ; 
                    __context__.SourceCodeLine = 868;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 869;
                    MNTH  .UpdateValue ( "March"  ) ; 
                    __context__.SourceCodeLine = 870;
                    MNTH_SHORT  .UpdateValue ( "Mar."  ) ; 
                    __context__.SourceCodeLine = 871;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 872;
                    MNTH  .UpdateValue ( "April"  ) ; 
                    __context__.SourceCodeLine = 873;
                    MNTH_SHORT  .UpdateValue ( "Apr."  ) ; 
                    __context__.SourceCodeLine = 874;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 875;
                    MNTH  .UpdateValue ( "May"  ) ; 
                    __context__.SourceCodeLine = 876;
                    MNTH_SHORT  .UpdateValue ( "May"  ) ; 
                    __context__.SourceCodeLine = 877;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 878;
                    MNTH  .UpdateValue ( "June"  ) ; 
                    __context__.SourceCodeLine = 879;
                    MNTH_SHORT  .UpdateValue ( "Jun."  ) ; 
                    __context__.SourceCodeLine = 880;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 881;
                    MNTH  .UpdateValue ( "July"  ) ; 
                    __context__.SourceCodeLine = 882;
                    MNTH_SHORT  .UpdateValue ( "Jul."  ) ; 
                    __context__.SourceCodeLine = 883;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 884;
                    MNTH  .UpdateValue ( "August"  ) ; 
                    __context__.SourceCodeLine = 885;
                    MNTH_SHORT  .UpdateValue ( "Aug."  ) ; 
                    __context__.SourceCodeLine = 886;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 887;
                    MNTH  .UpdateValue ( "September"  ) ; 
                    __context__.SourceCodeLine = 888;
                    MNTH_SHORT  .UpdateValue ( "Sept."  ) ; 
                    __context__.SourceCodeLine = 889;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 890;
                    MNTH  .UpdateValue ( "October"  ) ; 
                    __context__.SourceCodeLine = 891;
                    MNTH_SHORT  .UpdateValue ( "Oct."  ) ; 
                    __context__.SourceCodeLine = 892;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 893;
                    MNTH  .UpdateValue ( "November"  ) ; 
                    __context__.SourceCodeLine = 894;
                    MNTH_SHORT  .UpdateValue ( "Nov."  ) ; 
                    __context__.SourceCodeLine = 895;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 896;
                    MNTH  .UpdateValue ( "December"  ) ; 
                    __context__.SourceCodeLine = 897;
                    MNTH_SHORT  .UpdateValue ( "Dec."  ) ; 
                    __context__.SourceCodeLine = 898;
                    break ; 
                    } 
                
                goto default;
                default : 
                
                    { 
                    __context__.SourceCodeLine = 899;
                    MNTH  .UpdateValue ( "Error"  ) ; 
                    __context__.SourceCodeLine = 900;
                    MNTH_SHORT  .UpdateValue ( "Err."  ) ; 
                    } 
                break;
                
                } 
                
            
            __context__.SourceCodeLine = 903;
            switch ((int)_SplusNVRAM.G_IAWAYMSGINDEX)
            
                { 
                case 0 : 
                
                    { 
                    __context__.SourceCodeLine = 907;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: None."  ) ; 
                    __context__.SourceCodeLine = 908;
                    AWAY_DATE__DOLLAR__  .UpdateValue ( "Maintain Away Setpoint."  ) ; 
                    __context__.SourceCodeLine = 910;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "None"  ) ; 
                    __context__.SourceCodeLine = 911;
                    AWAY_DATE_SHORT__DOLLAR__  .UpdateValue ( "Maintain"  ) ; 
                    __context__.SourceCodeLine = 912;
                    break ; 
                    } 
                
                goto case 1 ;
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 917;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Wake"  ) ; 
                    __context__.SourceCodeLine = 918;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 920;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Wake"  ) ; 
                    __context__.SourceCodeLine = 921;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 922;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 927;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Leave"  ) ; 
                    __context__.SourceCodeLine = 928;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 930;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Leave"  ) ; 
                    __context__.SourceCodeLine = 931;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 932;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 937;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Return"  ) ; 
                    __context__.SourceCodeLine = 938;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 940;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Return"  ) ; 
                    __context__.SourceCodeLine = 941;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 942;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 947;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Sleep"  ) ; 
                    __context__.SourceCodeLine = 948;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 950;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Sleep"  ) ; 
                    __context__.SourceCodeLine = 951;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 952;
                    break ; 
                    } 
                
                goto default;
                default : 
                
                    { 
                    __context__.SourceCodeLine = 955;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Error"  ) ; 
                    } 
                break;
                
                } 
                
            
            
            }
            
        private void INITAWAYDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 971;
            G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
            __context__.SourceCodeLine = 972;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( G_TODAYJDAY ) ; 
            __context__.SourceCodeLine = 973;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 0 ) ; 
            
            }
            
        private void DOAWAYMODE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 986;
            
            __context__.SourceCodeLine = 990;
            _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 8 ) ; 
            __context__.SourceCodeLine = 991;
            CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
            __context__.SourceCodeLine = 992;
            AWAY_MODE_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 993;
            HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 994;
            _SplusNVRAM.G_IPREVSETPTS [ 0] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( CURRENT_HEAT_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 995;
            _SplusNVRAM.G_IPREVSETPTS [ 1] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( CURRENT_COOL_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 997;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            __context__.SourceCodeLine = 998;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            __context__.SourceCodeLine = 1000;
            UPDATEAWAYMESSAGE (  __context__  ) ; 
            
            }
            
        private void LOADSCHEDULES (  SplusExecutionContext __context__ ) 
            { 
            short IRESULT = 0;
            
            short IHANDLE = 0;
            
            ushort ISCHED = 0;
            
            FILE_INFO FI;
            FI  = new FILE_INFO();
            FI .PopulateDefaults();
            
            ushort IVERSION = 0;
            
            ushort ITEMP = 0;
            
            ushort IRECALLHOLDMODE = 0;
            
            ushort IRECALLAWAYMODE = 0;
            
            CrestronString SREADFILENAME;
            CrestronString SWRITEFILENAME;
            SREADFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            SWRITEFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            ushort IREADHANDLE = 0;
            ushort IWRITEHANDLE = 0;
            ushort INT = 0;
            
            
            __context__.SourceCodeLine = 1030;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 1032;
            IRECALLAWAYMODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1034;
            
            __context__.SourceCodeLine = 1038;
            SWRITEFILENAME  .UpdateValue ( GETFILENAME (  __context__  )  ) ; 
            __context__.SourceCodeLine = 1040;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( SWRITEFILENAME , ref FI ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1042;
                SREADFILENAME  .UpdateValue ( "\\NVRAM\\" + "tstat_" + Functions.ItoA (  (int) ( INSTANCE_ID  .UshortValue ) ) + ".dat"  ) ; 
                __context__.SourceCodeLine = 1044;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( SREADFILENAME , ref FI ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1046;
                    FindClose ( ) ; 
                    __context__.SourceCodeLine = 1047;
                    EndFileOperations ( ) ; 
                    __context__.SourceCodeLine = 1048;
                    return ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1053;
                    IREADHANDLE = (ushort) ( FileOpen( SREADFILENAME ,(ushort) (0 | 32768) ) ) ; 
                    __context__.SourceCodeLine = 1054;
                    IWRITEHANDLE = (ushort) ( FileOpen( SWRITEFILENAME ,(ushort) ((2 | 256) | 32768) ) ) ; 
                    __context__.SourceCodeLine = 1056;
                    while ( Functions.TestForTrue  ( ( Functions.Not( FileEOF( (short)( IREADHANDLE ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1058;
                        ReadInteger (  (short) ( IREADHANDLE ) ,  ref INT) ; 
                        __context__.SourceCodeLine = 1059;
                        WriteInteger (  (short) ( IWRITEHANDLE ) ,  (ushort) ( INT ) ) ; 
                        __context__.SourceCodeLine = 1056;
                        } 
                    
                    __context__.SourceCodeLine = 1062;
                    FileClose (  (short) ( IREADHANDLE ) ) ; 
                    __context__.SourceCodeLine = 1063;
                    FileClose (  (short) ( IWRITEHANDLE ) ) ; 
                    __context__.SourceCodeLine = 1065;
                    FileDelete ( SREADFILENAME ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1069;
            IHANDLE = (short) ( FileOpen( SWRITEFILENAME ,(ushort) (0 | 32768) ) ) ; 
            __context__.SourceCodeLine = 1071;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1074;
                IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IVERSION ) ) ; 
                __context__.SourceCodeLine = 1075;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION > 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1077;
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1083;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION >= 2 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1085;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IRECALLHOLDMODE ) ) ; 
                        __context__.SourceCodeLine = 1086;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IRECALLAWAYMODE ) ) ; 
                        __context__.SourceCodeLine = 1088;
                        if ( Functions.TestForTrue  ( ( IRECALLHOLDMODE)  ) ) 
                            {
                            __context__.SourceCodeLine = 1089;
                            HOLD_MODE_FB  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1091;
                            HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 1095;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)7; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( ISCHED  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ISCHED  >= __FN_FORSTART_VAL__1) && (ISCHED  <= __FN_FOREND_VAL__1) ) : ( (ISCHED  <= __FN_FORSTART_VAL__1) && (ISCHED  >= __FN_FOREND_VAL__1) ) ; ISCHED  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 1098;
                        
                        __context__.SourceCodeLine = 1101;
                        IRESULT = (short) ( ReadSignedInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].IHOUR ) ) ; 
                        __context__.SourceCodeLine = 1102;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].IMINUTE ) ) ; 
                        __context__.SourceCodeLine = 1103;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].ISETPOINT[ 0 ] ) ) ; 
                        __context__.SourceCodeLine = 1104;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].ISETPOINT[ 1 ] ) ) ; 
                        __context__.SourceCodeLine = 1095;
                        } 
                    
                    __context__.SourceCodeLine = 1109;
                    
                    __context__.SourceCodeLine = 1112;
                    IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ 8 ].ISETPOINT[ 0 ] ) ) ; 
                    __context__.SourceCodeLine = 1113;
                    IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ 8 ].ISETPOINT[ 1 ] ) ) ; 
                    __context__.SourceCodeLine = 1116;
                    if ( Functions.TestForTrue  ( ( IRECALLAWAYMODE)  ) ) 
                        {
                        __context__.SourceCodeLine = 1117;
                        DOAWAYMODE (  __context__  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1119;
                        AWAY_MODE_FB  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 1122;
                FileClose (  (short) ( IHANDLE ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1127;
                GenerateUserError ( "Unable to open file '{0}' for read. (Error code {1:d})\r\n", GETFILENAME (  __context__  ) , (short)IHANDLE) ; 
                } 
            
            __context__.SourceCodeLine = 1130;
            FindClose ( ) ; 
            __context__.SourceCodeLine = 1131;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 1133;
            
            
            }
            
        private void SAVESCHEDULES (  SplusExecutionContext __context__ ) 
            { 
            short IRESULT = 0;
            
            short IHANDLE = 0;
            
            ushort ISCHED = 0;
            
            ushort IVER = 0;
            
            ushort Z = 0;
            
            
            __context__.SourceCodeLine = 1160;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 1162;
            IHANDLE = (short) ( FileOpen( GETFILENAME( __context__ ) ,(ushort) (((1 + 512) + 256) | 32768) ) ) ; 
            __context__.SourceCodeLine = 1164;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1166;
                IVER = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 1167;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( IVER ) ) ) ; 
                __context__.SourceCodeLine = 1169;
                Z = (ushort) ( HOLD_MODE_FB  .Value ) ; 
                __context__.SourceCodeLine = 1170;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( Z ) ) ) ; 
                __context__.SourceCodeLine = 1171;
                Z = (ushort) ( AWAY_MODE_FB  .Value ) ; 
                __context__.SourceCodeLine = 1172;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( Z ) ) ) ; 
                __context__.SourceCodeLine = 1174;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)7; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( ISCHED  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ISCHED  >= __FN_FORSTART_VAL__1) && (ISCHED  <= __FN_FOREND_VAL__1) ) : ( (ISCHED  <= __FN_FORSTART_VAL__1) && (ISCHED  >= __FN_FOREND_VAL__1) ) ; ISCHED  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 1177;
                    IRESULT = (short) ( WriteSignedInteger( (short)( IHANDLE ) , (short)( G_SCHED[ ISCHED ].IHOUR ) ) ) ; 
                    __context__.SourceCodeLine = 1178;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].IMINUTE ) ) ) ; 
                    __context__.SourceCodeLine = 1179;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].ISETPOINT[ 0 ] ) ) ) ; 
                    __context__.SourceCodeLine = 1180;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].ISETPOINT[ 1 ] ) ) ) ; 
                    __context__.SourceCodeLine = 1174;
                    } 
                
                __context__.SourceCodeLine = 1184;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ 8 ].ISETPOINT[ 0 ] ) ) ) ; 
                __context__.SourceCodeLine = 1185;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ 8 ].ISETPOINT[ 1 ] ) ) ) ; 
                __context__.SourceCodeLine = 1187;
                FileClose (  (short) ( IHANDLE ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1192;
                GenerateUserError ( "ERROR: Unable to open file '{0}' for write. (Error code {1:d})\r\n", GETFILENAME (  __context__  ) , (short)IHANDLE) ; 
                } 
            
            __context__.SourceCodeLine = 1195;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 1197;
            
            
            }
            
        private ushort DAYTYPE (  SplusExecutionContext __context__, ushort IDAY ) 
            { 
            
            __context__.SourceCodeLine = 1218;
            if ( Functions.TestForTrue  ( ( Mod( IDAY , 6 ))  ) ) 
                {
                __context__.SourceCodeLine = 1219;
                return (ushort)( 0) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1221;
                return (ushort)( 1) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETSCHEDULEMINUTES (  SplusExecutionContext __context__, SCHEDULE SCHED ) 
            { 
            
            __context__.SourceCodeLine = 1239;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHED.IHOUR != -1))  ) ) 
                {
                __context__.SourceCodeLine = 1240;
                return (ushort)( ((SCHED.IHOUR * 60) + SCHED.IMINUTE)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1242;
                return (ushort)( 9999) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort ISSCHEDULEBEFORETIME (  SplusExecutionContext __context__, SCHEDULE SCHED , ushort ICOMPARETIMEINMINUTES ) 
            { 
            ushort ISCHEDTIMEINMINUTES = 0;
            
            
            __context__.SourceCodeLine = 1264;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHED.IHOUR != -1))  ) ) 
                { 
                __context__.SourceCodeLine = 1266;
                ISCHEDTIMEINMINUTES = (ushort) ( GETSCHEDULEMINUTES( __context__ , SCHED ) ) ; 
                __context__.SourceCodeLine = 1268;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOMPARETIMEINMINUTES >= ISCHEDTIMEINMINUTES ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1269;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 1272;
            return (ushort)( 0) ; 
            
            }
            
        private ushort GETSLEEPSCHEDULE (  SplusExecutionContext __context__, ushort IDAY ) 
            { 
            ushort IDAYTYPE = 0;
            
            
            __context__.SourceCodeLine = 1292;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 1294;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1296;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FRIDAY_NIGHT_IS_WEEKEND  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (IDAY == 5) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1297;
                    return (ushort)( 7) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1299;
                    return (ushort)( 3) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1303;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( SUNDAY_NIGHT_IS_WEEKDAY  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (IDAY == 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1304;
                    return (ushort)( 3) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1306;
                    return (ushort)( 7) ; 
                    }
                
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort DOESSCHEDULEOCCURONDAY (  SplusExecutionContext __context__, ushort ISCHEDULE , ushort IDAY ) 
            { 
            ushort IDAYTYPE = 0;
            
            
            __context__.SourceCodeLine = 1335;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 1337;
            switch ((int)ISCHEDULE)
            
                { 
                case 0 : 
                case 1 : 
                case 2 : 
                
                    {
                    __context__.SourceCodeLine = 1342;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 1343;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1345;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 4 ;
                case 4 : 
                goto case 5 ;
                case 5 : 
                goto case 6 ;
                case 6 : 
                
                    {
                    __context__.SourceCodeLine = 1350;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 1351;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1353;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 3 ;
                case 3 : 
                
                    {
                    __context__.SourceCodeLine = 1356;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) == 3))  ) ) 
                        {
                        __context__.SourceCodeLine = 1357;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1359;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 7 ;
                case 7 : 
                
                    {
                    __context__.SourceCodeLine = 1362;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) == 7))  ) ) 
                        {
                        __context__.SourceCodeLine = 1363;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1365;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                break;
                } 
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETCURRENTSCHEDULE (  SplusExecutionContext __context__, ushort IHOUR , ushort IMINUTE , ushort IDAY ) 
            { 
            ushort IPREVIOUSDAY = 0;
            
            ushort [] ISCHEDTOTEST;
            ISCHEDTOTEST  = new ushort[ 4 ];
            
            ushort IPREVDAYSLEEPSCHED = 0;
            
            ushort IDAYTYPE = 0;
            
            ushort ICURRENTTIMEINMINUTES = 0;
            
            
            __context__.SourceCodeLine = 1394;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 0 ].IHOUR == -1) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 1 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 2 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 3 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 4 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 5 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 6 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 7 ].IHOUR == -1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 1402;
                return (ushort)( 65535) ; 
                }
            
            __context__.SourceCodeLine = 1404;
            ICURRENTTIMEINMINUTES = (ushort) ( ((IHOUR * 60) + IMINUTE) ) ; 
            __context__.SourceCodeLine = 1405;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 1408;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1410;
                ISCHEDTOTEST [ 0] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1411;
                ISCHEDTOTEST [ 1] = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1412;
                ISCHEDTOTEST [ 2] = (ushort) ( 2 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1416;
                ISCHEDTOTEST [ 0] = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 1417;
                ISCHEDTOTEST [ 1] = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 1418;
                ISCHEDTOTEST [ 2] = (ushort) ( 6 ) ; 
                } 
            
            __context__.SourceCodeLine = 1422;
            ISCHEDTOTEST [ 3] = (ushort) ( GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 1425;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCHEDULEMINUTES( __context__ , G_SCHED[ ISCHEDTOTEST[ 3 ] ] ) >= 720 ))  ) ) 
                {
                __context__.SourceCodeLine = 1426;
                if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 3 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1426;
                    return (ushort)( ISCHEDTOTEST[ 3 ]) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1429;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 2 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1429;
                return (ushort)( ISCHEDTOTEST[ 2 ]) ; 
                }
            
            __context__.SourceCodeLine = 1430;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 1 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1430;
                return (ushort)( ISCHEDTOTEST[ 1 ]) ; 
                }
            
            __context__.SourceCodeLine = 1431;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 0 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1431;
                return (ushort)( ISCHEDTOTEST[ 0 ]) ; 
                }
            
            __context__.SourceCodeLine = 1436;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 1437;
                IPREVIOUSDAY = (ushort) ( (IDAY - 1) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1439;
                IPREVIOUSDAY = (ushort) ( 6 ) ; 
                }
            
            __context__.SourceCodeLine = 1442;
            IPREVDAYSLEEPSCHED = (ushort) ( GETSLEEPSCHEDULE( __context__ , (ushort)( IPREVIOUSDAY ) ) ) ; 
            __context__.SourceCodeLine = 1445;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCHEDULEMINUTES( __context__ , G_SCHED[ IPREVDAYSLEEPSCHED ] ) < 720 ))  ) ) 
                {
                __context__.SourceCodeLine = 1446;
                if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ IPREVDAYSLEEPSCHED ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1446;
                    return (ushort)( IPREVDAYSLEEPSCHED) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1450;
            return (ushort)( GETCURRENTSCHEDULE( __context__ , (ushort)( 23 ) , (ushort)( 59 ) , (ushort)( IPREVIOUSDAY ) )) ; 
            
            }
            
        private void RESTOREDEFAULTSCHEDULETIME (  SplusExecutionContext __context__, ushort ISCHEDULE ) 
            { 
            
            __context__.SourceCodeLine = 1469;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)ISCHEDULE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1471;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 6 ) ; 
                        __context__.SourceCodeLine = 1471;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1472;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 8 ) ; 
                        __context__.SourceCodeLine = 1472;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1473;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 17 ) ; 
                        __context__.SourceCodeLine = 1473;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1474;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 22 ) ; 
                        __context__.SourceCodeLine = 1474;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1475;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 6 ) ; 
                        __context__.SourceCodeLine = 1475;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1476;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 8 ) ; 
                        __context__.SourceCodeLine = 1476;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1477;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 17 ) ; 
                        __context__.SourceCodeLine = 1477;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1478;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 22 ) ; 
                        __context__.SourceCodeLine = 1478;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void UPDATESCHEDULETIME (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1523;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
                { 
                __context__.SourceCodeLine = 1525;
                SCHEDULE_TIME__DOLLAR__  .UpdateValue ( "--:--"  ) ; 
                __context__.SourceCodeLine = 1526;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1529;
            SCHEDULE_TIME__DOLLAR__  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE ))  ) ; 
            
            }
            
        private void ADJUSTSCALES (  SplusExecutionContext __context__ ) 
            { 
            ushort DOSOMETHING = 0;
            
            ushort TEMPSETPOINT = 0;
            ushort TEMPOUTSETPOINT = 0;
            
            ushort PRINTFLAG = 0;
            
            
            __context__.SourceCodeLine = 1537;
            DOSOMETHING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1539;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE != 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1542;
                if ( Functions.TestForTrue  ( ( HEATMODE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1544;
                    TEMPSETPOINT = (ushort) ( CURRENTSETPOINT[ 1 ] .UshortValue ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1546;
                    if ( Functions.TestForTrue  ( ( COOLMODE  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 1548;
                        TEMPSETPOINT = (ushort) ( CURRENTSETPOINT[ 2 ] .UshortValue ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1550;
                        if ( Functions.TestForTrue  ( ( SINGLEAUTOMODE  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1552;
                            TEMPSETPOINT = (ushort) ( CURRENTSETPOINT[ 3 ] .UshortValue ) ; 
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 1554;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPSETPOINT >= 380 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1556;
                    SETPOINTTEMPORARY = (short) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( TEMPSETPOINT ) ) ) ; 
                    __context__.SourceCodeLine = 1557;
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1563;
                    SETPOINTTEMPORARY = (short) ( TEMPSETPOINT ) ; 
                    __context__.SourceCodeLine = 1564;
                    
                    } 
                
                __context__.SourceCodeLine = 1569;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HEATMODE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1571;
                    DOSOMETHING = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1572;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY < MINHEATSETPOINT ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1574;
                        
                        __context__.SourceCodeLine = 1577;
                        SETPOINTTEMPORARY = (short) ( MINHEATSETPOINT ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1579;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY > MAXHEATSETPOINT ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1581;
                            
                            __context__.SourceCodeLine = 1584;
                            SETPOINTTEMPORARY = (short) ( MAXHEATSETPOINT ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1587;
                            DOSOMETHING = (ushort) ( 0 ) ; 
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1589;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COOLMODE  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1591;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY < MINCOOLSETPOINT ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1593;
                            
                            __context__.SourceCodeLine = 1596;
                            SETPOINTTEMPORARY = (short) ( MINCOOLSETPOINT ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1598;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY > MAXCOOLSETPOINT ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1600;
                                
                                __context__.SourceCodeLine = 1603;
                                SETPOINTTEMPORARY = (short) ( MAXCOOLSETPOINT ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1606;
                                DOSOMETHING = (ushort) ( 0 ) ; 
                                }
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1608;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SINGLEAUTOMODE  .Value == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1610;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY < MINAUTOSETPOINT ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1612;
                                
                                __context__.SourceCodeLine = 1615;
                                SETPOINTTEMPORARY = (short) ( MINAUTOSETPOINT ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1617;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SETPOINTTEMPORARY > MAXAUTOSETPOINT ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1619;
                                    
                                    __context__.SourceCodeLine = 1622;
                                    SETPOINTTEMPORARY = (short) ( MAXAUTOSETPOINT ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1625;
                                    DOSOMETHING = (ushort) ( 0 ) ; 
                                    }
                                
                                }
                            
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 1629;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DOSOMETHING == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1631;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPSETPOINT >= 380 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1635;
                        PRINTFLAG = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 1637;
                        if ( Functions.TestForTrue  ( ( HEATMODE  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1639;
                            REVISEDSETPOINT [ 1]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( SETPOINTTEMPORARY ) ) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1641;
                            if ( Functions.TestForTrue  ( ( COOLMODE  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1643;
                                REVISEDSETPOINT [ 2]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( SETPOINTTEMPORARY ) ) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1645;
                                if ( Functions.TestForTrue  ( ( SINGLEAUTOMODE  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1647;
                                    REVISEDSETPOINT [ 3]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( SETPOINTTEMPORARY ) ) ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1654;
                        PRINTFLAG = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1655;
                        if ( Functions.TestForTrue  ( ( HEATMODE  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1657;
                            REVISEDSETPOINT [ 1]  .Value = (ushort) ( SETPOINTTEMPORARY ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1659;
                            if ( Functions.TestForTrue  ( ( COOLMODE  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1661;
                                REVISEDSETPOINT [ 2]  .Value = (ushort) ( SETPOINTTEMPORARY ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1663;
                                if ( Functions.TestForTrue  ( ( SINGLEAUTOMODE  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1665;
                                    REVISEDSETPOINT [ 3]  .Value = (ushort) ( SETPOINTTEMPORARY ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 1669;
                    
                    } 
                
                } 
            
            
            }
            
        private void REFRESHSCHEDULESETPOINT__DOLLAR__ (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1678;
            SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
            __context__.SourceCodeLine = 1679;
            SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
            __context__.SourceCodeLine = 1680;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( ((G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ]) / 2) ))  ) ; 
            
            }
            
        private void REFRESHSCHEDULE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1686;
            CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
            __context__.SourceCodeLine = 1687;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            __context__.SourceCodeLine = 1688;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
                {
                __context__.SourceCodeLine = 1689;
                Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
                }
            
            
            }
            
        private ushort GETTEMPSCALEFROMSETPOINT (  SplusExecutionContext __context__, ushort TEMP ) 
            { 
            
            __context__.SourceCodeLine = 1711;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMP <= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 1712;
                return (ushort)( 2) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1713;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMP < 380 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1714;
                    return (ushort)( 1) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1716;
                    return (ushort)( 0) ; 
                    }
                
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void UPDATETEMPSCALE (  SplusExecutionContext __context__ ) 
            { 
            ushort INEWTEMPSCALE = 0;
            
            ushort [] SCALE;
            SCALE  = new ushort[ 6 ];
            
            
            __context__.SourceCodeLine = 1726;
            
            __context__.SourceCodeLine = 1730;
            SCALE [ 0] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MAX_HEAT_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1731;
            SCALE [ 1] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MIN_HEAT_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1732;
            SCALE [ 2] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MAX_COOL_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1733;
            SCALE [ 3] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MIN_COOL_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1734;
            SCALE [ 4] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MAX_SINGLEAUTO_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1735;
            SCALE [ 5] = (ushort) ( GETTEMPSCALEFROMSETPOINT( __context__ , (ushort)( AI_MIN_SINGLEAUTO_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1737;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 0 ] == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 1 ] == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 2 ] == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 3 ] == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 1741;
                INEWTEMPSCALE = (ushort) ( 0 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1743;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 0 ] == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 1 ] == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 2 ] == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SCALE[ 3 ] == 1) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1747;
                    INEWTEMPSCALE = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1750;
                    INEWTEMPSCALE = (ushort) ( 2 ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1753;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWTEMPSCALE == TEMP_SCALE))  ) ) 
                {
                __context__.SourceCodeLine = 1754;
                return ; 
                }
            
            __context__.SourceCodeLine = 1756;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWTEMPSCALE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1758;
                TEMP_SCALE_ERR  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1759;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1762;
            TEMP_SCALE_ERR  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1763;
            TEMP_SCALE = (ushort) ( INEWTEMPSCALE ) ; 
            __context__.SourceCodeLine = 1765;
            MAXHEATSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( AI_MAX_HEAT_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1766;
            MINHEATSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( AI_MIN_HEAT_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1767;
            MAXCOOLSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( AI_MAX_COOL_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1768;
            MINCOOLSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( AI_MIN_COOL_SETPOINT  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1769;
            MAXAUTOSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( ((AI_MAX_HEAT_SETPOINT  .UshortValue + AI_MAX_COOL_SETPOINT  .UshortValue) / 2) ) ) ) ; 
            __context__.SourceCodeLine = 1770;
            MINAUTOSETPOINT = (short) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( ((AI_MIN_HEAT_SETPOINT  .UshortValue + AI_MIN_COOL_SETPOINT  .UshortValue) / 2) ) ) ) ; 
            __context__.SourceCodeLine = 1772;
            
            __context__.SourceCodeLine = 1776;
            REFRESHSCHEDULESETPOINT__DOLLAR__ (  __context__  ) ; 
            __context__.SourceCodeLine = 1777;
            REFRESHSCHEDULE (  __context__  ) ; 
            __context__.SourceCodeLine = 1778;
            ADJUSTSCALES (  __context__  ) ; 
            
            }
            
        object AI_MAX_HEAT_SETPOINT_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1818;
                
                __context__.SourceCodeLine = 1821;
                UPDATETEMPSCALE (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object AI_MIN_HEAT_SETPOINT_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1828;
            
            __context__.SourceCodeLine = 1831;
            UPDATETEMPSCALE (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AI_MAX_COOL_SETPOINT_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1838;
        
        __context__.SourceCodeLine = 1841;
        UPDATETEMPSCALE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AI_MIN_COOL_SETPOINT_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1848;
        
        __context__.SourceCodeLine = 1851;
        UPDATETEMPSCALE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTSETPOINT_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SETPOINTTEMPORARY = 0;
        
        
        __context__.SourceCodeLine = 1884;
        SETPOINTTEMPORARY = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( DIRECTSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 1886;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HEATMODE  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1888;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY >= MINHEATSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY <= MAXHEATSETPOINT ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 1889;
                REVISEDSETPOINT [ 1]  .Value = (ushort) ( DIRECTSETPOINT  .UshortValue ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1891;
                GenerateUserWarning ( "Direct setpoint {0:d} out of Heat range", (short)DIRECTSETPOINT  .UshortValue) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1893;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COOLMODE  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1895;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY >= MINCOOLSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY <= MAXCOOLSETPOINT ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1896;
                    REVISEDSETPOINT [ 2]  .Value = (ushort) ( DIRECTSETPOINT  .UshortValue ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1898;
                    GenerateUserWarning ( "Direct setpoint {0:d} out of Cool range", (short)DIRECTSETPOINT  .UshortValue) ; 
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1900;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SINGLEAUTOMODE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1902;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY >= MINAUTOSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SETPOINTTEMPORARY <= MAXAUTOSETPOINT ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1903;
                        REVISEDSETPOINT [ 3]  .Value = (ushort) ( DIRECTSETPOINT  .UshortValue ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1905;
                        GenerateUserWarning ( "Direct setpoint {0:d} out of Auto(1pt) range", (short)DIRECTSETPOINT  .UshortValue) ; 
                        }
                    
                    } 
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDHEATSETPOINT_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SCHEDULEDHEATSETPOINTTEMPORARY = 0;
        
        
        __context__.SourceCodeLine = 1914;
        SCHEDULEDHEATSETPOINTTEMPORARY = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( SCHEDULEDHEATSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 1916;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDHEATSETPOINTTEMPORARY >= MINHEATSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDHEATSETPOINTTEMPORARY <= MAXHEATSETPOINT ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1918;
            SETPOINT [ (0 + 1)]  .Value = (ushort) ( SCHEDULEDHEATSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 1919;
            G_IRUNSCHEDULE = (ushort) ( (Mod( (G_IRUNSCHEDULE + 1) , 65535 ) + 1) ) ; 
            __context__.SourceCodeLine = 1920;
            RUNSCHEDULE  .Value = (ushort) ( G_IRUNSCHEDULE ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1923;
            GenerateUserWarning ( "ScheduledHeatSetpoint {0:d} out of Heat range", (short)SCHEDULEDHEATSETPOINT  .UshortValue) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDCOOLSETPOINT_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SCHEDULEDCOOLSETPOINTTEMPORARY = 0;
        
        
        __context__.SourceCodeLine = 1934;
        SCHEDULEDCOOLSETPOINTTEMPORARY = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( SCHEDULEDCOOLSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 1936;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDCOOLSETPOINTTEMPORARY >= MINCOOLSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDCOOLSETPOINTTEMPORARY <= MAXCOOLSETPOINT ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1938;
            SETPOINT [ (1 + 1)]  .Value = (ushort) ( SCHEDULEDCOOLSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 1939;
            G_IRUNSCHEDULE = (ushort) ( (Mod( (G_IRUNSCHEDULE + 1) , 65535 ) + 1) ) ; 
            __context__.SourceCodeLine = 1940;
            RUNSCHEDULE  .Value = (ushort) ( G_IRUNSCHEDULE ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1943;
            GenerateUserWarning ( "ScheduledCoolSetpoint {0:d} out of Cool range", (short)SCHEDULEDCOOLSETPOINT  .UshortValue) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDAUTO1PTSETPOINT_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SCHEDULEDAUTOSETPOINTTEMPORARY = 0;
        
        
        __context__.SourceCodeLine = 1953;
        SCHEDULEDAUTOSETPOINTTEMPORARY = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( SCHEDULEDAUTO1PTSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 1955;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDAUTOSETPOINTTEMPORARY >= MINAUTOSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SCHEDULEDAUTOSETPOINTTEMPORARY <= MAXAUTOSETPOINT ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1957;
            SETPOINT [ (2 + 1)]  .Value = (ushort) ( SCHEDULEDAUTO1PTSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 1958;
            G_IRUNSCHEDULE = (ushort) ( (Mod( (G_IRUNSCHEDULE + 1) , 65535 ) + 1) ) ; 
            __context__.SourceCodeLine = 1959;
            RUNSCHEDULE  .Value = (ushort) ( G_IRUNSCHEDULE ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1962;
            GenerateUserWarning ( "ScheduledAutoSetpoint {0:d} out of Auto range", (short)SCHEDULEDAUTO1PTSETPOINT  .UshortValue) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SINGLEAUTOMODE_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1971;
        ADJUSTSCALES (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_WAKE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1982;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1982;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Wake"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_LEAVE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1983;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1983;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Leave"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_RETURN_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1984;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1984;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Return"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_SLEEP_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1985;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 1985;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Sleep"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_WAKE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1986;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 1986;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Wake"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_LEAVE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1987;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 1987;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Leave"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_RETURN_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1988;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 6 ) ; 
        __context__.SourceCodeLine = 1988;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Return"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_SLEEP_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1989;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 7 ) ; 
        __context__.SourceCodeLine = 1989;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Sleep"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_WAKE_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1994;
        UPDATESCHEDULETIME (  __context__  ) ; 
        __context__.SourceCodeLine = 1995;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1996;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1997;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1998;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2000;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAY_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2005;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 2006;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Away"  ) ; 
        __context__.SourceCodeLine = 2008;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ 8 ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 2009;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ 8 ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 2010;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2011;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2013;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2015;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_UP_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2020;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2021;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2023;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2025;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2029;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) == 60))  ) ) 
                {
                __context__.SourceCodeLine = 2030;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR + 1) , 24 ) ) ; 
                }
            
            __context__.SourceCodeLine = 2031;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) , 60 ) ) ; 
            __context__.SourceCodeLine = 2034;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 2037;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_DOWN_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2042;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2043;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2045;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2047;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2051;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2053;
                if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR)  ) ) 
                    {
                    __context__.SourceCodeLine = 2054;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR - 1) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 2056;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( 23 ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 2059;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE)  ) ) 
                {
                __context__.SourceCodeLine = 2060;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - 15) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2062;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (60 - 15) ) ; 
                }
            
            __context__.SourceCodeLine = 2065;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 2068;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_UP_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2073;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2074;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2076;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2078;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2081;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR + 1) , 24 ) ) ; 
            }
        
        __context__.SourceCodeLine = 2083;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_DOWN_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2088;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2089;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2091;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2093;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2097;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR)  ) ) 
                {
                __context__.SourceCodeLine = 2098;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR - 1) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2100;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( 23 ) ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 2103;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_UP_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2108;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2109;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2111;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2113;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2117;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) , 60 ) ) ; 
            __context__.SourceCodeLine = 2120;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 2123;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_DOWN_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2128;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2129;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2131;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 2133;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2137;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE)  ) ) 
                {
                __context__.SourceCodeLine = 2138;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - 15) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2140;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (60 - 15) ) ; 
                }
            
            __context__.SourceCodeLine = 2143;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 2146;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HEAT_SETPOINT_UP_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPDEG = 0;
        
        
        __context__.SourceCodeLine = 2152;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
        __context__.SourceCodeLine = 2153;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2155;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) > (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) - DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2157;
                TEMPDEG = (ushort) ( (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) + DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 2158;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( TEMPDEG ) ) ) ; 
                __context__.SourceCodeLine = 2159;
                SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2164;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] > (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2166;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 2167;
                SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 2170;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 2172;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2173;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2175;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2177;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2178;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2179;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2180;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HEAT_SETPOINT_DOWN_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2185;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
        __context__.SourceCodeLine = 2187;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 2189;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2190;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2192;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2194;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2195;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2196;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2197;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOL_SETPOINT_UP_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2202;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
        __context__.SourceCodeLine = 2204;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 2206;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2207;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2209;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2211;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2212;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2213;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2214;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOL_SETPOINT_DOWN_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPDEG = 0;
        
        
        __context__.SourceCodeLine = 2220;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
        __context__.SourceCodeLine = 2221;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2223;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) < (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2225;
                TEMPDEG = (ushort) ( (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) - DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 2226;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( TEMPDEG ) ) ) ; 
                __context__.SourceCodeLine = 2227;
                SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2232;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] < (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2234;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 2235;
                SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 2239;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 2241;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2242;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2244;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2246;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2247;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2248;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2249;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_SETPOINT_UP_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2254;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + 1) <= MAXHEATSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + 1) <= MAXCOOLSETPOINT ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2256;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
            __context__.SourceCodeLine = 2257;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2261;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + 2) <= MAXHEATSETPOINT ))  ) ) 
                { 
                __context__.SourceCodeLine = 2263;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
                __context__.SourceCodeLine = 2264;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2266;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + 2) <= MAXCOOLSETPOINT ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2268;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
                    __context__.SourceCodeLine = 2269;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 2273;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 2274;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 2276;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2277;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2279;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2281;
        
        __context__.SourceCodeLine = 2286;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2287;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2288;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2289;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_SETPOINT_DOWN_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2296;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] - 1) >= MINHEATSETPOINT ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - 1) >= MINCOOLSETPOINT ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2298;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
            __context__.SourceCodeLine = 2299;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2303;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] - 2) >= MINHEATSETPOINT ))  ) ) 
                { 
                __context__.SourceCodeLine = 2305;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
                __context__.SourceCodeLine = 2306;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( MINHEATSETPOINT ) , (short)( MAXHEATSETPOINT ) ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2308;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - 2) >= MINCOOLSETPOINT ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2310;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
                    __context__.SourceCodeLine = 2311;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( MINCOOLSETPOINT ) , (short)( MAXCOOLSETPOINT ) ) ) ; 
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 2315;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 2316;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 2318;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2319;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2321;
            SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (short)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (short)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 2323;
        
        __context__.SourceCodeLine = 2327;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 2328;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2329;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 2330;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REMOVE_SCHEDULE_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2335;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 2336;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 2338;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE != 8))  ) ) 
            { 
            __context__.SourceCodeLine = 2340;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2341;
            UPDATESCHEDULETIME (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_UP_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2354;
        CreateWait ( "WAIT_SAVE" , 300 , WAIT_SAVE_Callback ) ;
        __context__.SourceCodeLine = 2355;
        RetimeWait ( (int)300, "WAIT_SAVE" ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void WAIT_SAVE_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2354;
            SAVESCHEDULES (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object HALF_DEGREE_C_STEPS_OnChange_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2361;
        REFRESHSCHEDULESETPOINT__DOLLAR__ (  __context__  ) ; 
        __context__.SourceCodeLine = 2362;
        REFRESHSCHEDULE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_PROGRAM_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 2372;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value != 0) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2373;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2375;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 2377;
        AWAY_MODE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2378;
        HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2379;
        _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) ) ; 
        __context__.SourceCodeLine = 2380;
        CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
        __context__.SourceCodeLine = 2381;
        CURRENT_DAYOFWEEK  .Value = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
        __context__.SourceCodeLine = 2382;
        UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
        __context__.SourceCodeLine = 2383;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
            {
            __context__.SourceCodeLine = 2384;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            }
        
        __context__.SourceCodeLine = 2386;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 2387;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_AWAY_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 2403;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2405;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2406;
            INITAWAYDATE (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2410;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 2412;
        DOAWAYMODE (  __context__  ) ; 
        __context__.SourceCodeLine = 2414;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 2415;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_HOLD_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 2439;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0))  ) ) 
            {
            __context__.SourceCodeLine = 2440;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2442;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 2444;
        HOLD_MODE_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2446;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 2447;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYDAY_INC_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2453;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 0))  ) ) 
            {
            __context__.SourceCodeLine = 2454;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( (_SplusNVRAM.G_IAWAYMSGINDEX + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 2456;
        _SplusNVRAM.G_LTARGETJDAY = (uint) ( (_SplusNVRAM.G_LTARGETJDAY + 1) ) ; 
        __context__.SourceCodeLine = 2458;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYDAY_DEC_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2463;
        _SplusNVRAM.G_LTARGETJDAY = (uint) ( (_SplusNVRAM.G_LTARGETJDAY - 1) ) ; 
        __context__.SourceCodeLine = 2465;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY <= G_TODAYJDAY ))  ) ) 
            { 
            __context__.SourceCodeLine = 2467;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2468;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( G_TODAYJDAY ) ; 
            } 
        
        __context__.SourceCodeLine = 2471;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYSCHED_INC_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2476;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_IAWAYMSGINDEX < 4 ))  ) ) 
            {
            __context__.SourceCodeLine = 2477;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( (_SplusNVRAM.G_IAWAYMSGINDEX + 1) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2480;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 2482;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY <= G_TODAYJDAY ))  ) ) 
            {
            __context__.SourceCodeLine = 2483;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( (G_TODAYJDAY + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 2485;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    short IERRCODE = 0;
    
    FILE_INFO FIDATAFILE;
    FIDATAFILE  = new FILE_INFO();
    FIDATAFILE .PopulateDefaults();
    
    ushort ICURRENTHOUR = 0;
    ushort ICURRENTMIN = 0;
    ushort ICURRENTTIME = 0;
    ushort ICURRENTDAY = 0;
    
    ushort ILASTCHECKEDTIME = 0;
    ushort ILASTCHECKEDDAY = 0;
    
    ushort I = 0;
    ushort IOFFSET = 0;
    
    ushort INEWSCHEDULE = 0;
    
    ushort WKENDOFFSET = 0;
    
    ushort SEEDVALUE = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 2500;
        _SplusNVRAM.TTEXT [ 0] = (ushort) ( 70 ) ; 
        __context__.SourceCodeLine = 2501;
        _SplusNVRAM.TTEXT [ 1] = (ushort) ( 67 ) ; 
        __context__.SourceCodeLine = 2503;
        TEMP_SCALE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 2504;
        TEMP_SCALE_ERR  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2506;
        SEEDVALUE = (ushort) ( (((Functions.GetHourNum() * 24) + Functions.GetMinutesNum()) + Functions.GetSecondsNum()) ) ; 
        __context__.SourceCodeLine = 2507;
        G_IRUNSCHEDULE = (ushort) ( Functions.Random( (ushort)( 1 ) , (ushort)( 65534 ) ) ) ; 
        __context__.SourceCodeLine = 2521;
        G_SCHED [ 0] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2522;
        G_SCHED [ 0] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2523;
        G_SCHED [ 0] . ISETPOINT [ 0] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2524;
        G_SCHED [ 0] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2527;
        G_SCHED [ 1] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2528;
        G_SCHED [ 1] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2529;
        G_SCHED [ 1] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2530;
        G_SCHED [ 1] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2533;
        G_SCHED [ 2] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2534;
        G_SCHED [ 2] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2535;
        G_SCHED [ 2] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2536;
        G_SCHED [ 2] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2539;
        G_SCHED [ 3] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2540;
        G_SCHED [ 3] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2541;
        G_SCHED [ 3] . ISETPOINT [ 0] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2542;
        G_SCHED [ 3] . ISETPOINT [ 1] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 2546;
        G_SCHED [ 4] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2547;
        G_SCHED [ 4] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2548;
        G_SCHED [ 4] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2549;
        G_SCHED [ 4] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2552;
        G_SCHED [ 5] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2553;
        G_SCHED [ 5] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2554;
        G_SCHED [ 5] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2555;
        G_SCHED [ 5] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2558;
        G_SCHED [ 6] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2559;
        G_SCHED [ 6] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2560;
        G_SCHED [ 6] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2561;
        G_SCHED [ 6] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2564;
        G_SCHED [ 7] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2565;
        G_SCHED [ 7] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2566;
        G_SCHED [ 7] . ISETPOINT [ 0] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2567;
        G_SCHED [ 7] . ISETPOINT [ 1] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 2570;
        G_SCHED [ 8] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2571;
        G_SCHED [ 8] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2574;
        _SplusNVRAM.G_IPREVSETPTS [ 0] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2575;
        _SplusNVRAM.G_IPREVSETPTS [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2577;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_IEDITSCHEDULE < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_IEDITSCHEDULE > 7 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2578;
            _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 2580;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_ICURRENTSCHEDULE < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_ICURRENTSCHEDULE > 8 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2581;
            _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 65535 ) ; 
            }
        
        __context__.SourceCodeLine = 2583;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 2586;
        if ( Functions.TestForTrue  ( ( USE_DEFAULT_SCHEDULE_TIMES  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2589;
            G_SCHED [ 0] . IHOUR = (short) ( 6 ) ; 
            __context__.SourceCodeLine = 2590;
            G_SCHED [ 1] . IHOUR = (short) ( 8 ) ; 
            __context__.SourceCodeLine = 2591;
            G_SCHED [ 2] . IHOUR = (short) ( 17 ) ; 
            __context__.SourceCodeLine = 2592;
            G_SCHED [ 3] . IHOUR = (short) ( 22 ) ; 
            __context__.SourceCodeLine = 2595;
            G_SCHED [ 4] . IHOUR = (short) ( 6 ) ; 
            __context__.SourceCodeLine = 2596;
            G_SCHED [ 5] . IHOUR = (short) ( 8 ) ; 
            __context__.SourceCodeLine = 2597;
            G_SCHED [ 6] . IHOUR = (short) ( 17 ) ; 
            __context__.SourceCodeLine = 2598;
            G_SCHED [ 7] . IHOUR = (short) ( 22 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2603;
            G_SCHED [ 0] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2604;
            G_SCHED [ 1] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2605;
            G_SCHED [ 2] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2606;
            G_SCHED [ 3] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2609;
            G_SCHED [ 4] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2610;
            G_SCHED [ 5] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2611;
            G_SCHED [ 6] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2612;
            G_SCHED [ 7] . IHOUR = (short) ( -1 ) ; 
            } 
        
        __context__.SourceCodeLine = 2616;
        LOADSCHEDULES (  __context__  ) ; 
        __context__.SourceCodeLine = 2618;
        Functions.Delay (  (int) ( 100 ) ) ; 
        __context__.SourceCodeLine = 2620;
        CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
        __context__.SourceCodeLine = 2621;
        G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
        __context__.SourceCodeLine = 2623;
        ILASTCHECKEDTIME = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
        __context__.SourceCodeLine = 2624;
        ILASTCHECKEDDAY = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
        __context__.SourceCodeLine = 2629;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 2631;
            ICURRENTHOUR = (ushort) ( Functions.GetHourNum() ) ; 
            __context__.SourceCodeLine = 2632;
            ICURRENTDAY = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
            __context__.SourceCodeLine = 2634;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTHOUR >= 12 ))  ) ) 
                {
                __context__.SourceCodeLine = 2635;
                PM_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2637;
                PM_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 2639;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURRENTDAY != CURRENT_DAYOFWEEK  .Value))  ) ) 
                { 
                __context__.SourceCodeLine = 2641;
                CURRENT_DAYOFWEEK  .Value = (ushort) ( ICURRENTDAY ) ; 
                __context__.SourceCodeLine = 2642;
                G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 2646;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 8) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2649;
                ICURRENTMIN = (ushort) ( Functions.GetMinutesNum() ) ; 
                __context__.SourceCodeLine = 2650;
                ICURRENTDAY = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
                __context__.SourceCodeLine = 2651;
                ICURRENTTIME = (ushort) ( ((ICURRENTHOUR * 60) + ICURRENTMIN) ) ; 
                __context__.SourceCodeLine = 2653;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDTIME != ICURRENTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDDAY != ICURRENTDAY) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2655;
                    
                    __context__.SourceCodeLine = 2660;
                    INEWSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( ICURRENTHOUR ) , (ushort)( ICURRENTMIN ) , (ushort)( ICURRENTDAY ) ) ) ; 
                    __context__.SourceCodeLine = 2662;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWSCHEDULE == 65535))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2664;
                        _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 65535 ) ; 
                        __context__.SourceCodeLine = 2665;
                        CURRENT_SCHEDULE  .Value = (ushort) ( 65535 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2667;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ INEWSCHEDULE ].IHOUR != -1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2671;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWSCHEDULE != _SplusNVRAM.G_ICURRENTSCHEDULE))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2673;
                                _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( INEWSCHEDULE ) ; 
                                __context__.SourceCodeLine = 2674;
                                CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
                                __context__.SourceCodeLine = 2675;
                                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                                __context__.SourceCodeLine = 2676;
                                Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2682;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GETSCHEDULEMINUTES( __context__ , G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ] ) == ICURRENTTIME) ) && Functions.TestForTrue ( DOESSCHEDULEOCCURONDAY( __context__ , (ushort)( _SplusNVRAM.G_ICURRENTSCHEDULE ) , (ushort)( ICURRENTDAY ) ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2684;
                                    UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                                    __context__.SourceCodeLine = 2685;
                                    Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        }
                    
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2692;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2694;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY < G_TODAYJDAY ))  ) ) 
                        {
                        __context__.SourceCodeLine = 2695;
                        Functions.Pulse ( 10, RUN ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2697;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_LTARGETJDAY == G_TODAYJDAY))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2699;
                            ICURRENTMIN = (ushort) ( Functions.GetMinutesNum() ) ; 
                            __context__.SourceCodeLine = 2700;
                            ICURRENTTIME = (ushort) ( ((ICURRENTHOUR * 60) + ICURRENTMIN) ) ; 
                            __context__.SourceCodeLine = 2702;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDTIME != ICURRENTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDDAY != ICURRENTDAY) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2705;
                                INEWSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( ICURRENTHOUR ) , (ushort)( ICURRENTMIN ) , (ushort)( ICURRENTDAY ) ) ) ; 
                                __context__.SourceCodeLine = 2708;
                                switch ((int)ICURRENTDAY)
                                
                                    { 
                                    case 0 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2712;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( SUNDAY_NIGHT_IS_WEEKDAY  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 4) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 2713;
                                            WKENDOFFSET = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 2715;
                                            WKENDOFFSET = (ushort) ( 4 ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 2717;
                                        break ; 
                                        } 
                                    
                                    goto case 5 ;
                                    case 5 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2722;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FRIDAY_NIGHT_IS_WEEKEND  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 4) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 2723;
                                            WKENDOFFSET = (ushort) ( 4 ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 2725;
                                        break ; 
                                        } 
                                    
                                    goto case 6 ;
                                    case 6 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2730;
                                        WKENDOFFSET = (ushort) ( 4 ) ; 
                                        __context__.SourceCodeLine = 2731;
                                        break ; 
                                        } 
                                    
                                    goto default;
                                    default : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2734;
                                        WKENDOFFSET = (ushort) ( 0 ) ; 
                                        } 
                                    break;
                                    
                                    } 
                                    
                                
                                __context__.SourceCodeLine = 2737;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INEWSCHEDULE != 3) ) && Functions.TestForTrue ( Functions.BoolToInt (INEWSCHEDULE != 7) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2739;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEWSCHEDULE >= ((_SplusNVRAM.G_IAWAYMSGINDEX + WKENDOFFSET) - 1) ))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 2740;
                                        Functions.Pulse ( 10, RUN ) ; 
                                        }
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 2743;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INEWSCHEDULE >= ((_SplusNVRAM.G_IAWAYMSGINDEX + WKENDOFFSET) - 1) ) ) && Functions.TestForTrue ( PM_FB  .Value )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2745;
                                        Functions.Pulse ( 10, RUN ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 2752;
            ILASTCHECKEDTIME = (ushort) ( ICURRENTTIME ) ; 
            __context__.SourceCodeLine = 2753;
            ILASTCHECKEDDAY = (ushort) ( ICURRENTDAY ) ; 
            __context__.SourceCodeLine = 2755;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 2629;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.TTEXT  = new ushort[ 3 ];
    _SplusNVRAM.G_IPREVSETPTS  = new ushort[ 2 ];
    G_SCHED  = new SCHEDULE[ 9 ];
    for( uint i = 0; i < 9; i++ )
    {
        G_SCHED [i] = new SCHEDULE( this, true );
        G_SCHED [i].PopulateCustomAttributeList( false );
        
    }
    
    WEEKDAY_WAKE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_WAKE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_WAKE__DigitalInput__, WEEKDAY_WAKE );
    
    WEEKDAY_LEAVE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_LEAVE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_LEAVE__DigitalInput__, WEEKDAY_LEAVE );
    
    WEEKDAY_RETURN = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_RETURN__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_RETURN__DigitalInput__, WEEKDAY_RETURN );
    
    WEEKDAY_SLEEP = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_SLEEP__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_SLEEP__DigitalInput__, WEEKDAY_SLEEP );
    
    WEEKEND_WAKE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_WAKE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_WAKE__DigitalInput__, WEEKEND_WAKE );
    
    WEEKEND_LEAVE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_LEAVE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_LEAVE__DigitalInput__, WEEKEND_LEAVE );
    
    WEEKEND_RETURN = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_RETURN__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_RETURN__DigitalInput__, WEEKEND_RETURN );
    
    WEEKEND_SLEEP = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_SLEEP__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_SLEEP__DigitalInput__, WEEKEND_SLEEP );
    
    AWAY = new Crestron.Logos.SplusObjects.DigitalInput( AWAY__DigitalInput__, this );
    m_DigitalInputList.Add( AWAY__DigitalInput__, AWAY );
    
    TIME_UP = new Crestron.Logos.SplusObjects.DigitalInput( TIME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_UP__DigitalInput__, TIME_UP );
    
    TIME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( TIME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_DOWN__DigitalInput__, TIME_DOWN );
    
    HOUR_UP = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_UP__DigitalInput__, HOUR_UP );
    
    HOUR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_DOWN__DigitalInput__, HOUR_DOWN );
    
    MINUTE_UP = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_UP__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_UP__DigitalInput__, MINUTE_UP );
    
    MINUTE_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_DOWN__DigitalInput__, MINUTE_DOWN );
    
    HEAT_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SETPOINT_UP__DigitalInput__, HEAT_SETPOINT_UP );
    
    HEAT_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SETPOINT_DOWN__DigitalInput__, HEAT_SETPOINT_DOWN );
    
    COOL_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SETPOINT_UP__DigitalInput__, COOL_SETPOINT_UP );
    
    COOL_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SETPOINT_DOWN__DigitalInput__, COOL_SETPOINT_DOWN );
    
    AUTO_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_SETPOINT_UP__DigitalInput__, AUTO_SETPOINT_UP );
    
    AUTO_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_SETPOINT_DOWN__DigitalInput__, AUTO_SETPOINT_DOWN );
    
    REMOVE_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( REMOVE_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( REMOVE_SCHEDULE__DigitalInput__, REMOVE_SCHEDULE );
    
    RESET_SCHEDULES = new Crestron.Logos.SplusObjects.DigitalInput( RESET_SCHEDULES__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_SCHEDULES__DigitalInput__, RESET_SCHEDULES );
    
    HALF_DEGREE_C_STEPS = new Crestron.Logos.SplusObjects.DigitalInput( HALF_DEGREE_C_STEPS__DigitalInput__, this );
    m_DigitalInputList.Add( HALF_DEGREE_C_STEPS__DigitalInput__, HALF_DEGREE_C_STEPS );
    
    RUN_PROGRAM = new Crestron.Logos.SplusObjects.DigitalInput( RUN_PROGRAM__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_PROGRAM__DigitalInput__, RUN_PROGRAM );
    
    RUN_AWAY = new Crestron.Logos.SplusObjects.DigitalInput( RUN_AWAY__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_AWAY__DigitalInput__, RUN_AWAY );
    
    RUN_HOLD = new Crestron.Logos.SplusObjects.DigitalInput( RUN_HOLD__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_HOLD__DigitalInput__, RUN_HOLD );
    
    USE_DEFAULT_SCHEDULE_TIMES = new Crestron.Logos.SplusObjects.DigitalInput( USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__, this );
    m_DigitalInputList.Add( USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__, USE_DEFAULT_SCHEDULE_TIMES );
    
    SUNDAY_NIGHT_IS_WEEKDAY = new Crestron.Logos.SplusObjects.DigitalInput( SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__, this );
    m_DigitalInputList.Add( SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__, SUNDAY_NIGHT_IS_WEEKDAY );
    
    FRIDAY_NIGHT_IS_WEEKEND = new Crestron.Logos.SplusObjects.DigitalInput( FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__, this );
    m_DigitalInputList.Add( FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__, FRIDAY_NIGHT_IS_WEEKEND );
    
    AWAYDAY_INC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYDAY_INC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYDAY_INC__DigitalInput__, AWAYDAY_INC );
    
    AWAYDAY_DEC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYDAY_DEC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYDAY_DEC__DigitalInput__, AWAYDAY_DEC );
    
    AWAYSCHED_INC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYSCHED_INC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYSCHED_INC__DigitalInput__, AWAYSCHED_INC );
    
    HEATMODE = new Crestron.Logos.SplusObjects.DigitalInput( HEATMODE__DigitalInput__, this );
    m_DigitalInputList.Add( HEATMODE__DigitalInput__, HEATMODE );
    
    COOLMODE = new Crestron.Logos.SplusObjects.DigitalInput( COOLMODE__DigitalInput__, this );
    m_DigitalInputList.Add( COOLMODE__DigitalInput__, COOLMODE );
    
    SINGLEAUTOMODE = new Crestron.Logos.SplusObjects.DigitalInput( SINGLEAUTOMODE__DigitalInput__, this );
    m_DigitalInputList.Add( SINGLEAUTOMODE__DigitalInput__, SINGLEAUTOMODE );
    
    DUALAUTOMODE = new Crestron.Logos.SplusObjects.DigitalInput( DUALAUTOMODE__DigitalInput__, this );
    m_DigitalInputList.Add( DUALAUTOMODE__DigitalInput__, DUALAUTOMODE );
    
    SCHEDULE_DUE = new Crestron.Logos.SplusObjects.DigitalOutput( SCHEDULE_DUE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCHEDULE_DUE__DigitalOutput__, SCHEDULE_DUE );
    
    PM_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PM_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PM_FB__DigitalOutput__, PM_FB );
    
    TEMP_SCALE_ERR = new Crestron.Logos.SplusObjects.DigitalOutput( TEMP_SCALE_ERR__DigitalOutput__, this );
    m_DigitalOutputList.Add( TEMP_SCALE_ERR__DigitalOutput__, TEMP_SCALE_ERR );
    
    RUN = new Crestron.Logos.SplusObjects.DigitalOutput( RUN__DigitalOutput__, this );
    m_DigitalOutputList.Add( RUN__DigitalOutput__, RUN );
    
    AWAY_MODE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( AWAY_MODE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( AWAY_MODE_FB__DigitalOutput__, AWAY_MODE_FB );
    
    HOLD_MODE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( HOLD_MODE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( HOLD_MODE_FB__DigitalOutput__, HOLD_MODE_FB );
    
    CURRENT_HEAT_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_HEAT_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_HEAT_SP__AnalogSerialInput__, CURRENT_HEAT_SP );
    
    CURRENT_COOL_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_COOL_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_COOL_SP__AnalogSerialInput__, CURRENT_COOL_SP );
    
    CURRENT_AUTO_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_AUTO_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_AUTO_SP__AnalogSerialInput__, CURRENT_AUTO_SP );
    
    INSTANCE_ID = new Crestron.Logos.SplusObjects.AnalogInput( INSTANCE_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INSTANCE_ID__AnalogSerialInput__, INSTANCE_ID );
    
    AI_MAX_HEAT_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MAX_HEAT_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MAX_HEAT_SETPOINT__AnalogSerialInput__, AI_MAX_HEAT_SETPOINT );
    
    AI_MIN_HEAT_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MIN_HEAT_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MIN_HEAT_SETPOINT__AnalogSerialInput__, AI_MIN_HEAT_SETPOINT );
    
    AI_MAX_COOL_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MAX_COOL_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MAX_COOL_SETPOINT__AnalogSerialInput__, AI_MAX_COOL_SETPOINT );
    
    AI_MIN_COOL_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MIN_COOL_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MIN_COOL_SETPOINT__AnalogSerialInput__, AI_MIN_COOL_SETPOINT );
    
    AI_MIN_SINGLEAUTO_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MIN_SINGLEAUTO_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MIN_SINGLEAUTO_SETPOINT__AnalogSerialInput__, AI_MIN_SINGLEAUTO_SETPOINT );
    
    AI_MAX_SINGLEAUTO_SETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( AI_MAX_SINGLEAUTO_SETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AI_MAX_SINGLEAUTO_SETPOINT__AnalogSerialInput__, AI_MAX_SINGLEAUTO_SETPOINT );
    
    DIRECTSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( DIRECTSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DIRECTSETPOINT__AnalogSerialInput__, DIRECTSETPOINT );
    
    SCHEDULEDHEATSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDHEATSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDHEATSETPOINT__AnalogSerialInput__, SCHEDULEDHEATSETPOINT );
    
    SCHEDULEDCOOLSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDCOOLSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDCOOLSETPOINT__AnalogSerialInput__, SCHEDULEDCOOLSETPOINT );
    
    SCHEDULEDAUTO1PTSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDAUTO1PTSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDAUTO1PTSETPOINT__AnalogSerialInput__, SCHEDULEDAUTO1PTSETPOINT );
    
    DEADBAND = new Crestron.Logos.SplusObjects.AnalogInput( DEADBAND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEADBAND__AnalogSerialInput__, DEADBAND );
    
    CURRENTSETPOINT = new InOutArray<AnalogInput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CURRENTSETPOINT[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( CURRENTSETPOINT__AnalogSerialInput__ + i, CURRENTSETPOINT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( CURRENTSETPOINT__AnalogSerialInput__ + i, CURRENTSETPOINT[i+1] );
    }
    
    CURRENT_SCHEDULE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_SCHEDULE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_SCHEDULE__AnalogSerialOutput__, CURRENT_SCHEDULE );
    
    CURRENT_DAYOFWEEK = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_DAYOFWEEK__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_DAYOFWEEK__AnalogSerialOutput__, CURRENT_DAYOFWEEK );
    
    RUNSCHEDULE = new Crestron.Logos.SplusObjects.AnalogOutput( RUNSCHEDULE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RUNSCHEDULE__AnalogSerialOutput__, RUNSCHEDULE );
    
    REVISEDSETPOINT = new InOutArray<AnalogOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        REVISEDSETPOINT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( REVISEDSETPOINT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( REVISEDSETPOINT__AnalogSerialOutput__ + i, REVISEDSETPOINT[i+1] );
    }
    
    SETPOINT = new InOutArray<AnalogOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        SETPOINT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SETPOINT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SETPOINT__AnalogSerialOutput__ + i, SETPOINT[i+1] );
    }
    
    PATH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PATH__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( PATH__DOLLAR____AnalogSerialInput__, PATH__DOLLAR__ );
    
    SCHEDULE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__, SCHEDULE_NAME__DOLLAR__ );
    
    SCHEDULE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__, SCHEDULE_TIME__DOLLAR__ );
    
    AWAY_SCHEDULE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__, AWAY_SCHEDULE__DOLLAR__ );
    
    AWAY_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_DATE__DOLLAR____AnalogSerialOutput__, AWAY_DATE__DOLLAR__ );
    
    AWAY_SCHEDULE_SHORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__, AWAY_SCHEDULE_SHORT__DOLLAR__ );
    
    AWAY_DATE_SHORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__, AWAY_DATE_SHORT__DOLLAR__ );
    
    SCHEDULE_SETPOINT__DOLLAR__ = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        SCHEDULE_SETPOINT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ + i, SCHEDULE_SETPOINT__DOLLAR__[i+1] );
    }
    
    WAIT_SAVE_Callback = new WaitFunction( WAIT_SAVE_CallbackFn );
    
    AI_MAX_HEAT_SETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AI_MAX_HEAT_SETPOINT_OnChange_0, false ) );
    AI_MIN_HEAT_SETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AI_MIN_HEAT_SETPOINT_OnChange_1, false ) );
    AI_MAX_COOL_SETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AI_MAX_COOL_SETPOINT_OnChange_2, false ) );
    AI_MIN_COOL_SETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AI_MIN_COOL_SETPOINT_OnChange_3, false ) );
    DIRECTSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DIRECTSETPOINT_OnChange_4, false ) );
    SCHEDULEDHEATSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDHEATSETPOINT_OnChange_5, false ) );
    SCHEDULEDCOOLSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDCOOLSETPOINT_OnChange_6, false ) );
    SCHEDULEDAUTO1PTSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDAUTO1PTSETPOINT_OnChange_7, false ) );
    SINGLEAUTOMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLEAUTOMODE_OnPush_8, false ) );
    DUALAUTOMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLEAUTOMODE_OnPush_8, false ) );
    COOLMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLEAUTOMODE_OnPush_8, false ) );
    HEATMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLEAUTOMODE_OnPush_8, false ) );
    WEEKDAY_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_9, false ) );
    WEEKDAY_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_LEAVE_OnPush_10, false ) );
    WEEKDAY_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_RETURN_OnPush_11, false ) );
    WEEKDAY_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_SLEEP_OnPush_12, false ) );
    WEEKEND_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_WAKE_OnPush_13, false ) );
    WEEKEND_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_LEAVE_OnPush_14, false ) );
    WEEKEND_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_RETURN_OnPush_15, false ) );
    WEEKEND_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_SLEEP_OnPush_16, false ) );
    WEEKDAY_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKDAY_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKDAY_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKDAY_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKEND_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKEND_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKEND_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    WEEKEND_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_17, false ) );
    AWAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAY_OnPush_18, false ) );
    TIME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_UP_OnPush_19, false ) );
    TIME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_DOWN_OnPush_20, false ) );
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_21, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_DOWN_OnPush_22, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_UP_OnPush_23, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_DOWN_OnPush_24, false ) );
    HEAT_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SETPOINT_UP_OnPush_25, false ) );
    HEAT_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SETPOINT_DOWN_OnPush_26, false ) );
    COOL_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SETPOINT_UP_OnPush_27, false ) );
    COOL_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SETPOINT_DOWN_OnPush_28, false ) );
    AUTO_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_SETPOINT_UP_OnPush_29, false ) );
    AUTO_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_SETPOINT_DOWN_OnPush_30, false ) );
    REMOVE_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOVE_SCHEDULE_OnPush_31, false ) );
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    TIME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    TIME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    HEAT_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    HEAT_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    COOL_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    COOL_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    AUTO_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    AUTO_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    REMOVE_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_32, false ) );
    HALF_DEGREE_C_STEPS.OnDigitalChange.Add( new InputChangeHandlerWrapper( HALF_DEGREE_C_STEPS_OnChange_33, false ) );
    RUN_PROGRAM.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_PROGRAM_OnPush_34, false ) );
    RUN_AWAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_AWAY_OnPush_35, false ) );
    RUN_HOLD.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_HOLD_OnPush_36, false ) );
    AWAYDAY_INC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYDAY_INC_OnPush_37, false ) );
    AWAYDAY_DEC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYDAY_DEC_OnPush_38, false ) );
    AWAYSCHED_INC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYSCHED_INC_OnPush_39, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_TSTATEX_SCHEDULER__5_2_PROGRAM__V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAIT_SAVE_Callback;


const uint WEEKDAY_WAKE__DigitalInput__ = 0;
const uint WEEKDAY_LEAVE__DigitalInput__ = 1;
const uint WEEKDAY_RETURN__DigitalInput__ = 2;
const uint WEEKDAY_SLEEP__DigitalInput__ = 3;
const uint WEEKEND_WAKE__DigitalInput__ = 4;
const uint WEEKEND_LEAVE__DigitalInput__ = 5;
const uint WEEKEND_RETURN__DigitalInput__ = 6;
const uint WEEKEND_SLEEP__DigitalInput__ = 7;
const uint AWAY__DigitalInput__ = 8;
const uint TIME_UP__DigitalInput__ = 9;
const uint TIME_DOWN__DigitalInput__ = 10;
const uint HOUR_UP__DigitalInput__ = 11;
const uint HOUR_DOWN__DigitalInput__ = 12;
const uint MINUTE_UP__DigitalInput__ = 13;
const uint MINUTE_DOWN__DigitalInput__ = 14;
const uint HEAT_SETPOINT_UP__DigitalInput__ = 15;
const uint HEAT_SETPOINT_DOWN__DigitalInput__ = 16;
const uint COOL_SETPOINT_UP__DigitalInput__ = 17;
const uint COOL_SETPOINT_DOWN__DigitalInput__ = 18;
const uint AUTO_SETPOINT_UP__DigitalInput__ = 19;
const uint AUTO_SETPOINT_DOWN__DigitalInput__ = 20;
const uint REMOVE_SCHEDULE__DigitalInput__ = 21;
const uint RESET_SCHEDULES__DigitalInput__ = 22;
const uint HALF_DEGREE_C_STEPS__DigitalInput__ = 23;
const uint RUN_PROGRAM__DigitalInput__ = 24;
const uint RUN_AWAY__DigitalInput__ = 25;
const uint RUN_HOLD__DigitalInput__ = 26;
const uint USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__ = 27;
const uint SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__ = 28;
const uint FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__ = 29;
const uint AWAYDAY_INC__DigitalInput__ = 30;
const uint AWAYDAY_DEC__DigitalInput__ = 31;
const uint AWAYSCHED_INC__DigitalInput__ = 32;
const uint HEATMODE__DigitalInput__ = 33;
const uint COOLMODE__DigitalInput__ = 34;
const uint SINGLEAUTOMODE__DigitalInput__ = 35;
const uint DUALAUTOMODE__DigitalInput__ = 36;
const uint CURRENT_HEAT_SP__AnalogSerialInput__ = 0;
const uint CURRENT_COOL_SP__AnalogSerialInput__ = 1;
const uint CURRENT_AUTO_SP__AnalogSerialInput__ = 2;
const uint INSTANCE_ID__AnalogSerialInput__ = 3;
const uint AI_MAX_HEAT_SETPOINT__AnalogSerialInput__ = 4;
const uint AI_MIN_HEAT_SETPOINT__AnalogSerialInput__ = 5;
const uint AI_MAX_COOL_SETPOINT__AnalogSerialInput__ = 6;
const uint AI_MIN_COOL_SETPOINT__AnalogSerialInput__ = 7;
const uint AI_MIN_SINGLEAUTO_SETPOINT__AnalogSerialInput__ = 8;
const uint AI_MAX_SINGLEAUTO_SETPOINT__AnalogSerialInput__ = 9;
const uint DIRECTSETPOINT__AnalogSerialInput__ = 10;
const uint SCHEDULEDHEATSETPOINT__AnalogSerialInput__ = 11;
const uint SCHEDULEDCOOLSETPOINT__AnalogSerialInput__ = 12;
const uint SCHEDULEDAUTO1PTSETPOINT__AnalogSerialInput__ = 13;
const uint DEADBAND__AnalogSerialInput__ = 14;
const uint PATH__DOLLAR____AnalogSerialInput__ = 15;
const uint CURRENTSETPOINT__AnalogSerialInput__ = 16;
const uint SCHEDULE_DUE__DigitalOutput__ = 0;
const uint PM_FB__DigitalOutput__ = 1;
const uint TEMP_SCALE_ERR__DigitalOutput__ = 2;
const uint RUN__DigitalOutput__ = 3;
const uint AWAY_MODE_FB__DigitalOutput__ = 4;
const uint HOLD_MODE_FB__DigitalOutput__ = 5;
const uint CURRENT_SCHEDULE__AnalogSerialOutput__ = 0;
const uint CURRENT_DAYOFWEEK__AnalogSerialOutput__ = 1;
const uint RUNSCHEDULE__AnalogSerialOutput__ = 2;
const uint SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__ = 3;
const uint SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__ = 4;
const uint AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__ = 5;
const uint AWAY_DATE__DOLLAR____AnalogSerialOutput__ = 6;
const uint AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__ = 7;
const uint AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__ = 8;
const uint REVISEDSETPOINT__AnalogSerialOutput__ = 9;
const uint SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ = 12;
const uint SETPOINT__AnalogSerialOutput__ = 15;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort [] TTEXT;
            [SplusStructAttribute(1, false, true)]
            public ushort G_IEDITSCHEDULE = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort [] G_IPREVSETPTS;
            [SplusStructAttribute(3, false, true)]
            public ushort G_ICURRENTSCHEDULE = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort G_IAWAYMSGINDEX = 0;
            [SplusStructAttribute(5, false, true)]
            public uint G_LTARGETJDAY = 0;
            
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

[SplusStructAttribute(-1, true, false)]
public class SCHEDULE : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public short  IHOUR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  IMINUTE = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  [] ISETPOINT;
    
    
    public SCHEDULE( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ISETPOINT  = new ushort[ 2 ];
        
        
    }
    
}

}
