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
using SonosLibrary_v3_0.SimplPlusInterfaces;
using SonosProLibrary_v3_0.DataStructures;
using SonosProLibrary_v3_0.Diagnostics.Impl;
using SonosProLibrary_v3_0.Devices.Events;
using SonosProLibrary_v3_0.System.Enums;
using SonosProLibrary_v3_0.System.Events;
using SonosLibrary_v3_0.SimplPlusInterfaces.Events;
using SonosProLibrary_v3_0.System;
using SonosProLibrary_v3_0.Diagnostics.Events;
using SonosProLibrary_v3_0.Diagnostics.Enums;
using SonosProLibrary_v3_0.Logging.Enums;
using SonosProLibrary_v3_0.Diagnostics;
using SonosProLibrary_v3_0.API;
using SonosProLibrary_v3_0.Devices;
using Crestron.AppHelperClassesv2_0;
using AppHelperClasses;
using Crestron.AppHelperClasses;
using Crestron.CRPC.CIPDirectTransport;
using Crestron.CRPC;
using Crestron.CRPC.Common;
using CRPCConnectionHelper;
using Crestron.CRPC.MediaPlayer;

namespace CrestronModule_SONOS_DEVICE_ENGINE_V3_0_0
{
    public class CrestronModuleClass_SONOS_DEVICE_ENGINE_V3_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PLAY;
        Crestron.Logos.SplusObjects.DigitalInput PAUSE;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLEPLAYPAUSE;
        Crestron.Logos.SplusObjects.DigitalInput NEXTTRACK;
        Crestron.Logos.SplusObjects.DigitalInput PREVIOUSTRACK;
        Crestron.Logos.SplusObjects.DigitalInput PLAYERVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput PLAYERVOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput GROUPVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput GROUPVOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput MUTEPLAYER;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTEPLAYER;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLEPLAYERMUTE;
        Crestron.Logos.SplusObjects.DigitalInput MUTEGROUP;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTEGROUP;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLEGROUPMUTE;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLEREPEATMODE;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLESHUFFLEMODE;
        Crestron.Logos.SplusObjects.DigitalInput SHUFFLEMODEON;
        Crestron.Logos.SplusObjects.DigitalInput SHUFFLEMODEOFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SETREPEATMODE;
        Crestron.Logos.SplusObjects.AnalogInput PLAYERVOLUMELEVEL;
        Crestron.Logos.SplusObjects.AnalogInput PLAYERVOLUMELEVELBAR;
        Crestron.Logos.SplusObjects.AnalogInput GROUPVOLUMELEVEL;
        Crestron.Logos.SplusObjects.AnalogInput GROUPVOLUMELEVELBAR;
        Crestron.Logos.SplusObjects.AnalogInput FAVORITESELECT;
        Crestron.Logos.SplusObjects.StringInput SETSONOSZONENAME;
        Crestron.Logos.SplusObjects.StringInput FAVORITENAMESELECT;
        Crestron.Logos.SplusObjects.StringInput FROM_MEDIA_PLAYER;
        Crestron.Logos.SplusObjects.DigitalOutput OFFLINE;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput DISCOVERINGGROUPS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GETTINGFAVORITES_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ISGROUPED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ISPLAYING_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ISPAUSED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ISBUFFERING_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ISIDLE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NEXTTRACKAVAILABLE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PREVIOUSTRACKAVAILABLE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWPROGRESS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput REPEATALLAVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput REPEATONEAVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput SHUFFLEAVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput SHUFFLEISON;
        Crestron.Logos.SplusObjects.DigitalOutput PLAYERVOLUMEISMUTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PLAYERVOLUMEISFIXED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEISMUTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEISFIXED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput PLAYERVOLUME_LEVEL_FB;
        Crestron.Logos.SplusObjects.AnalogOutput PLAYERVOLUME_LEVEL_BAR_FB;
        Crestron.Logos.SplusObjects.AnalogOutput GROUPVOLUME_LEVEL_FB;
        Crestron.Logos.SplusObjects.AnalogOutput GROUPVOLUME_LEVEL_BAR_FB;
        Crestron.Logos.SplusObjects.AnalogOutput NOWPLAYINGLENGTHSECONDS;
        Crestron.Logos.SplusObjects.AnalogOutput NOWPLAYINGPOSITIONSECONDS;
        Crestron.Logos.SplusObjects.AnalogOutput NOWPLAYINGPOSITIONGAUGE;
        Crestron.Logos.SplusObjects.AnalogOutput REPEATMODE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput NUMBEROFFAVORITES;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGCONTAINERNAME;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGTRACKNAME;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGARTIST;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGALBUM;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGSTREAMINFO;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGIMAGEURL;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGLENGTHSECONDS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYINGPOSITIONSECONDS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PLAYBACKERROR;
        Crestron.Logos.SplusObjects.StringOutput PLAYERNAME;
        Crestron.Logos.SplusObjects.StringOutput GROUPNAME;
        Crestron.Logos.SplusObjects.StringOutput TO_MEDIA_PLAYER;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGINFO;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> FAVORITESNAMES;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> FAVORITESDESCRIPTIONS;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> FAVORITESIMAGEURLS;
        SonosLibrary_v3_0.SimplPlusInterfaces.MediaPlayerDeviceSimplPlusInterface SIMPLSHARPDEVICEUI;
        private void REGISTERDELEGATES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 146;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERCONNECTIONUPDATE , UPDATECONNECTIONSTATUS ) 
            SIMPLSHARPDEVICEUI .PlayerConnectionUpdate  = UPDATECONNECTIONSTATUS; ; 
            __context__.SourceCodeLine = 147;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERBUSYUPDATE , UPDATEBUSYSTATUS ) 
            SIMPLSHARPDEVICEUI .PlayerBusyUpdate  = UPDATEBUSYSTATUS; ; 
            __context__.SourceCodeLine = 148;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , FAVORITESLISTUPDATE , UPDATEFAVORITESLIST ) 
            SIMPLSHARPDEVICEUI .FavoritesListUpdate  = UPDATEFAVORITESLIST; ; 
            __context__.SourceCodeLine = 149;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERINFOUPDATE , UPDATEPLAYERINFO ) 
            SIMPLSHARPDEVICEUI .PlayerInfoUpdate  = UPDATEPLAYERINFO; ; 
            __context__.SourceCodeLine = 150;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERSTATEUPDATE , UPDATEPLAYERSTATE ) 
            SIMPLSHARPDEVICEUI .PlayerStateUpdate  = UPDATEPLAYERSTATE; ; 
            __context__.SourceCodeLine = 151;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERNOWPLAYINGINFOUPDATE , UPDATENOWPLAYINGINFO ) 
            SIMPLSHARPDEVICEUI .PlayerNowPlayingInfoUpdate  = UPDATENOWPLAYINGINFO; ; 
            __context__.SourceCodeLine = 152;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERNOWPLAYINGPROGRESSUPDATE , UPDATENOWPLAYINGPROGRESS ) 
            SIMPLSHARPDEVICEUI .PlayerNowPlayingProgressUpdate  = UPDATENOWPLAYINGPROGRESS; ; 
            __context__.SourceCodeLine = 153;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERVOLUMEUPDATE , UPDATEPLAYERVOLUME ) 
            SIMPLSHARPDEVICEUI .PlayerVolumeUpdate  = UPDATEPLAYERVOLUME; ; 
            __context__.SourceCodeLine = 154;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , GROUPVOLUMEUPDATE , UPDATEGROUPVOLUME ) 
            SIMPLSHARPDEVICEUI .GroupVolumeUpdate  = UPDATEGROUPVOLUME; ; 
            __context__.SourceCodeLine = 156;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , PLAYERPLAYBACKERRORUPDATE , UPDATEPLAYBACKERROR ) 
            SIMPLSHARPDEVICEUI .PlayerPlaybackErrorUpdate  = UPDATEPLAYBACKERROR; ; 
            __context__.SourceCodeLine = 157;
            // RegisterDelegate( SIMPLSHARPDEVICEUI , MESSAGEOUT , SENDSTREAM ) 
            SIMPLSHARPDEVICEUI .MessageOut  = SENDSTREAM; ; 
            
            }
            
        public void UPDATECONNECTIONSTATUS ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 162;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.OfflineState == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 163;
                    OFFLINE  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 165;
                    OFFLINE  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEBUSYSTATUS ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 170;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.BusyStatus == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 171;
                    BUSY_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 173;
                    BUSY_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 175;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.DiscoveringGroups == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 176;
                    DISCOVERINGGROUPS_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 178;
                    DISCOVERINGGROUPS_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 180;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.GettingFavorites == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 181;
                    GETTINGFAVORITES_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 183;
                    GETTINGFAVORITES_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 184;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.OfflineState == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 185;
                    OFFLINE  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 187;
                    OFFLINE  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEFAVORITESLIST ( ) 
            { 
            ushort I = 0;
            
            ushort COUNT = 0;
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 196;
                COUNT = (ushort) ( SIMPLSHARPDEVICEUI.NumberOfFavorites ) ; 
                __context__.SourceCodeLine = 197;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( COUNT > 30 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 198;
                    COUNT = (ushort) ( 30 ) ; 
                    }
                
                __context__.SourceCodeLine = 199;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)COUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 201;
                    FAVORITESNAMES [ I]  .UpdateValue ( SIMPLSHARPDEVICEUI . ListOfFavorites [ (I - 1) ]  ) ; 
                    __context__.SourceCodeLine = 202;
                    FAVORITESDESCRIPTIONS [ I]  .UpdateValue ( SIMPLSHARPDEVICEUI . ListOfFavoritesDescriptions [ (I - 1) ]  ) ; 
                    __context__.SourceCodeLine = 203;
                    FAVORITESIMAGEURLS [ I]  .UpdateValue ( SIMPLSHARPDEVICEUI . ListOfFavoritesImageUrLs [ (I - 1) ]  ) ; 
                    __context__.SourceCodeLine = 199;
                    } 
                
                __context__.SourceCodeLine = 205;
                NUMBEROFFAVORITES  .Value = (ushort) ( COUNT ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEPLAYERINFO ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 212;
                PLAYERNAME  .UpdateValue ( SIMPLSHARPDEVICEUI . DeviceZoneName  ) ; 
                __context__.SourceCodeLine = 213;
                GROUPNAME  .UpdateValue ( SIMPLSHARPDEVICEUI . GroupName  ) ; 
                __context__.SourceCodeLine = 215;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.IsGrouped == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 216;
                    ISGROUPED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 218;
                    ISGROUPED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEPLAYERSTATE ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 224;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.IsPlaying == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 225;
                    ISPLAYING_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 227;
                    ISPLAYING_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 229;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.IsPaused == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 230;
                    ISPAUSED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 232;
                    ISPAUSED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 234;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.IsBuffering == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 235;
                    ISBUFFERING_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 237;
                    ISBUFFERING_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 239;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.IsIdle == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 240;
                    ISIDLE_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 242;
                    ISIDLE_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 244;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.NextTrackAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 245;
                    NEXTTRACKAVAILABLE_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 247;
                    NEXTTRACKAVAILABLE_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 249;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.PreviousTrackAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 250;
                    PREVIOUSTRACKAVAILABLE_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 252;
                    PREVIOUSTRACKAVAILABLE_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 254;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.ShowTrackProgress == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 255;
                    SHOWPROGRESS_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 257;
                    SHOWPROGRESS_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 259;
                NOWPLAYINGPOSITIONSECONDS  .Value = (ushort) ( SIMPLSHARPDEVICEUI.NowPlayingTrackPositionSeconds ) ; 
                __context__.SourceCodeLine = 260;
                NOWPLAYINGPOSITIONSECONDS__DOLLAR__  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingTrackPositionString  ) ; 
                __context__.SourceCodeLine = 262;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.RepeatAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 263;
                    REPEATALLAVAILABLE  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 265;
                    REPEATALLAVAILABLE  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 267;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.RepeatOneAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 268;
                    REPEATONEAVAILABLE  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 270;
                    REPEATONEAVAILABLE  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 272;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.ShuffleAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 273;
                    SHUFFLEAVAILABLE  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 275;
                    SHUFFLEAVAILABLE  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 277;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.RepeatEnabled == "True"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 279;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.RepeatOneEnabled == "True"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 281;
                        REPEATMODE_FB  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 285;
                        REPEATMODE_FB  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 291;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.RepeatOneEnabled == "True"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 293;
                        REPEATMODE_FB  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 297;
                        REPEATMODE_FB  .Value = (ushort) ( 3 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 301;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.ShuffleEnabled == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 302;
                    SHUFFLEISON  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 304;
                    SHUFFLEISON  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATENOWPLAYINGINFO ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 310;
                NOWPLAYINGCONTAINERNAME  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingContainerName  ) ; 
                __context__.SourceCodeLine = 311;
                NOWPLAYINGTRACKNAME  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingTrackName  ) ; 
                __context__.SourceCodeLine = 312;
                NOWPLAYINGARTIST  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingArtist  ) ; 
                __context__.SourceCodeLine = 313;
                NOWPLAYINGALBUM  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingAlbum  ) ; 
                __context__.SourceCodeLine = 314;
                NOWPLAYINGSTREAMINFO  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingStreamInfo  ) ; 
                __context__.SourceCodeLine = 315;
                NOWPLAYINGIMAGEURL  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingImageUrl  ) ; 
                __context__.SourceCodeLine = 316;
                NOWPLAYINGLENGTHSECONDS__DOLLAR__  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingTrackLengthString  ) ; 
                __context__.SourceCodeLine = 317;
                NOWPLAYINGLENGTHSECONDS  .Value = (ushort) ( SIMPLSHARPDEVICEUI.NowPlayingTrackLengthSeconds ) ; 
                __context__.SourceCodeLine = 319;
                NOWPLAYINGINFO [ 1]  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingLines [ 0 ]  ) ; 
                __context__.SourceCodeLine = 320;
                NOWPLAYINGINFO [ 2]  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingLines [ 1 ]  ) ; 
                __context__.SourceCodeLine = 321;
                NOWPLAYINGINFO [ 3]  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingLines [ 2 ]  ) ; 
                __context__.SourceCodeLine = 322;
                NOWPLAYINGINFO [ 4]  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingLines [ 3 ]  ) ; 
                __context__.SourceCodeLine = 323;
                NOWPLAYINGINFO [ 5]  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingLines [ 4 ]  ) ; 
                __context__.SourceCodeLine = 325;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.NextTrackAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 326;
                    NEXTTRACKAVAILABLE_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 328;
                    NEXTTRACKAVAILABLE_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 330;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.PreviousTrackAvailable == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 331;
                    PREVIOUSTRACKAVAILABLE_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 333;
                    PREVIOUSTRACKAVAILABLE_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 335;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.ShowTrackProgress == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 336;
                    SHOWPROGRESS_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 338;
                    SHOWPROGRESS_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATENOWPLAYINGPROGRESS ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 345;
                NOWPLAYINGPOSITIONSECONDS  .Value = (ushort) ( SIMPLSHARPDEVICEUI.NowPlayingTrackPositionSeconds ) ; 
                __context__.SourceCodeLine = 346;
                NOWPLAYINGPOSITIONGAUGE  .Value = (ushort) ( SIMPLSHARPDEVICEUI.NowPlayingTrackPositionGauge ) ; 
                __context__.SourceCodeLine = 347;
                NOWPLAYINGPOSITIONSECONDS__DOLLAR__  .UpdateValue ( SIMPLSHARPDEVICEUI . NowPlayingTrackPositionString  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEPLAYERVOLUME ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 352;
                PLAYERVOLUME_LEVEL_FB  .Value = (ushort) ( SIMPLSHARPDEVICEUI.PlayerVolumeLevel ) ; 
                __context__.SourceCodeLine = 353;
                PLAYERVOLUME_LEVEL_BAR_FB  .Value = (ushort) ( SIMPLSHARPDEVICEUI.PlayerVolumeLevelBar ) ; 
                __context__.SourceCodeLine = 355;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.PlayerIsMuted == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 356;
                    PLAYERVOLUMEISMUTED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 358;
                    PLAYERVOLUMEISMUTED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 360;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.PlayerVolumeIsFixed == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 361;
                    PLAYERVOLUMEISFIXED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 363;
                    PLAYERVOLUMEISFIXED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEGROUPVOLUME ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 369;
                GROUPVOLUME_LEVEL_FB  .Value = (ushort) ( SIMPLSHARPDEVICEUI.GroupVolumeLevel ) ; 
                __context__.SourceCodeLine = 370;
                GROUPVOLUME_LEVEL_BAR_FB  .Value = (ushort) ( SIMPLSHARPDEVICEUI.GroupVolumeLevelBar ) ; 
                __context__.SourceCodeLine = 372;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.GroupIsMuted == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 373;
                    GROUPVOLUMEISMUTED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 375;
                    GROUPVOLUMEISMUTED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 377;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIMPLSHARPDEVICEUI.GroupVolumeIsFixed == "True"))  ) ) 
                    {
                    __context__.SourceCodeLine = 378;
                    GROUPVOLUMEISFIXED_FB  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 380;
                    GROUPVOLUMEISFIXED_FB  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void UPDATEPLAYBACKERROR ( ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 386;
                PLAYBACKERROR  .UpdateValue ( SIMPLSHARPDEVICEUI . PlaybackError  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void SENDSTREAM ( SimplSharpString STREAMOUT ) 
            { 
            CrestronString S;
            S  = new CrestronString( InheritedStringEncoding, 255, this );
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 393;
                S  =  ( STREAMOUT  .ToString()  )  .ToString() ; 
                __context__.SourceCodeLine = 394;
                TO_MEDIA_PLAYER  .UpdateValue ( S  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object PLAY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 404;
                SIMPLSHARPDEVICEUI . Play ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PAUSE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 409;
            SIMPLSHARPDEVICEUI . Pause ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TOGGLEPLAYPAUSE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 414;
        SIMPLSHARPDEVICEUI . TogglePlayPause ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXTTRACK_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 419;
        SIMPLSHARPDEVICEUI . NextTrack ( ) ; 
        __context__.SourceCodeLine = 419;
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREVIOUSTRACK_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 424;
        SIMPLSHARPDEVICEUI . PreviousTrack ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLEREPEATMODE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 429;
        SIMPLSHARPDEVICEUI . ToggleRepeat ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLESHUFFLEMODE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 434;
        SIMPLSHARPDEVICEUI . ToggleShuffle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHUFFLEMODEON_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 439;
        SIMPLSHARPDEVICEUI . SetShuffleMode ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHUFFLEMODEOFF_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 444;
        SIMPLSHARPDEVICEUI . SetShuffleMode ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETREPEATMODE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 450;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 451;
        SIMPLSHARPDEVICEUI . SetRepeatMode ( (ushort)( I )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYERVOLUMEUP_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 456;
        SIMPLSHARPDEVICEUI . PlayerVolumeUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYERVOLUMEDOWN_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 461;
        SIMPLSHARPDEVICEUI . PlayerVolumeDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPVOLUMEUP_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 466;
        SIMPLSHARPDEVICEUI . GroupVolumeUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPVOLUMEDOWN_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 471;
        SIMPLSHARPDEVICEUI . GroupVolumeDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEPLAYER_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 477;
        SIMPLSHARPDEVICEUI . MutePlayer ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNMUTEPLAYER_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 483;
        SIMPLSHARPDEVICEUI . UnmutePlayer ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLEPLAYERMUTE_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 488;
        SIMPLSHARPDEVICEUI . TogglePlayerMuteState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEGROUP_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 493;
        SIMPLSHARPDEVICEUI . MuteGroup ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNMUTEGROUP_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 499;
        SIMPLSHARPDEVICEUI . UnmuteGroup ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLEGROUPMUTE_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 504;
        SIMPLSHARPDEVICEUI . ToggleGroupMuteState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYERVOLUMELEVEL_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 510;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PLAYERVOLUMELEVEL  .UshortValue >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PLAYERVOLUMELEVEL  .UshortValue <= 100 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 512;
            SIMPLSHARPDEVICEUI . SetPlayerVolumeLevel ( (ushort)( PLAYERVOLUMELEVEL  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYERVOLUMELEVELBAR_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 518;
        SIMPLSHARPDEVICEUI . SetPlayerVolumeLevelBar ( (ushort)( PLAYERVOLUMELEVELBAR  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPVOLUMELEVEL_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 523;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( GROUPVOLUMELEVEL  .UshortValue >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( GROUPVOLUMELEVEL  .UshortValue <= 100 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 525;
            SIMPLSHARPDEVICEUI . SetGroupVolumeLevel ( (ushort)( GROUPVOLUMELEVEL  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPVOLUMELEVELBAR_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 531;
        SIMPLSHARPDEVICEUI . SetGroupVolumeLevelBar ( (ushort)( GROUPVOLUMELEVELBAR  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVORITESELECT_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 537;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( FAVORITESELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( FAVORITESELECT  .UshortValue <= 30 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 539;
            SIMPLSHARPDEVICEUI . PlayFavorite ( (int)( FAVORITESELECT  .IntValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVORITENAMESELECT_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 545;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FAVORITENAMESELECT != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 547;
            SIMPLSHARPDEVICEUI . PlayFavoriteByName ( FAVORITENAMESELECT .ToString()) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETSONOSZONENAME_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 553;
        SIMPLSHARPDEVICEUI . SetDefaultPlayerName ( SETSONOSZONENAME .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MEDIA_PLAYER_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 559;
        SIMPLSHARPDEVICEUI . MessageIn ( FROM_MEDIA_PLAYER .ToString()) ; 
        
        
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
        
        __context__.SourceCodeLine = 570;
        OFFLINE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 571;
        REGISTERDELEGATES (  __context__  ) ; 
        __context__.SourceCodeLine = 572;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    PLAY = new Crestron.Logos.SplusObjects.DigitalInput( PLAY__DigitalInput__, this );
    m_DigitalInputList.Add( PLAY__DigitalInput__, PLAY );
    
    PAUSE = new Crestron.Logos.SplusObjects.DigitalInput( PAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( PAUSE__DigitalInput__, PAUSE );
    
    TOGGLEPLAYPAUSE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLEPLAYPAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLEPLAYPAUSE__DigitalInput__, TOGGLEPLAYPAUSE );
    
    NEXTTRACK = new Crestron.Logos.SplusObjects.DigitalInput( NEXTTRACK__DigitalInput__, this );
    m_DigitalInputList.Add( NEXTTRACK__DigitalInput__, NEXTTRACK );
    
    PREVIOUSTRACK = new Crestron.Logos.SplusObjects.DigitalInput( PREVIOUSTRACK__DigitalInput__, this );
    m_DigitalInputList.Add( PREVIOUSTRACK__DigitalInput__, PREVIOUSTRACK );
    
    PLAYERVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( PLAYERVOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( PLAYERVOLUMEUP__DigitalInput__, PLAYERVOLUMEUP );
    
    PLAYERVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( PLAYERVOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PLAYERVOLUMEDOWN__DigitalInput__, PLAYERVOLUMEDOWN );
    
    GROUPVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( GROUPVOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( GROUPVOLUMEUP__DigitalInput__, GROUPVOLUMEUP );
    
    GROUPVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( GROUPVOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( GROUPVOLUMEDOWN__DigitalInput__, GROUPVOLUMEDOWN );
    
    MUTEPLAYER = new Crestron.Logos.SplusObjects.DigitalInput( MUTEPLAYER__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEPLAYER__DigitalInput__, MUTEPLAYER );
    
    UNMUTEPLAYER = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTEPLAYER__DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTEPLAYER__DigitalInput__, UNMUTEPLAYER );
    
    TOGGLEPLAYERMUTE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLEPLAYERMUTE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLEPLAYERMUTE__DigitalInput__, TOGGLEPLAYERMUTE );
    
    MUTEGROUP = new Crestron.Logos.SplusObjects.DigitalInput( MUTEGROUP__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEGROUP__DigitalInput__, MUTEGROUP );
    
    UNMUTEGROUP = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTEGROUP__DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTEGROUP__DigitalInput__, UNMUTEGROUP );
    
    TOGGLEGROUPMUTE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLEGROUPMUTE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLEGROUPMUTE__DigitalInput__, TOGGLEGROUPMUTE );
    
    TOGGLEREPEATMODE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLEREPEATMODE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLEREPEATMODE__DigitalInput__, TOGGLEREPEATMODE );
    
    TOGGLESHUFFLEMODE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLESHUFFLEMODE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLESHUFFLEMODE__DigitalInput__, TOGGLESHUFFLEMODE );
    
    SHUFFLEMODEON = new Crestron.Logos.SplusObjects.DigitalInput( SHUFFLEMODEON__DigitalInput__, this );
    m_DigitalInputList.Add( SHUFFLEMODEON__DigitalInput__, SHUFFLEMODEON );
    
    SHUFFLEMODEOFF = new Crestron.Logos.SplusObjects.DigitalInput( SHUFFLEMODEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SHUFFLEMODEOFF__DigitalInput__, SHUFFLEMODEOFF );
    
    SETREPEATMODE = new InOutArray<DigitalInput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        SETREPEATMODE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SETREPEATMODE__DigitalInput__ + i, SETREPEATMODE__DigitalInput__, this );
        m_DigitalInputList.Add( SETREPEATMODE__DigitalInput__ + i, SETREPEATMODE[i+1] );
    }
    
    OFFLINE = new Crestron.Logos.SplusObjects.DigitalOutput( OFFLINE__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFFLINE__DigitalOutput__, OFFLINE );
    
    BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY_FB__DigitalOutput__, BUSY_FB );
    
    DISCOVERINGGROUPS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( DISCOVERINGGROUPS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISCOVERINGGROUPS_FB__DigitalOutput__, DISCOVERINGGROUPS_FB );
    
    GETTINGFAVORITES_FB = new Crestron.Logos.SplusObjects.DigitalOutput( GETTINGFAVORITES_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( GETTINGFAVORITES_FB__DigitalOutput__, GETTINGFAVORITES_FB );
    
    ISGROUPED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ISGROUPED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISGROUPED_FB__DigitalOutput__, ISGROUPED_FB );
    
    ISPLAYING_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ISPLAYING_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISPLAYING_FB__DigitalOutput__, ISPLAYING_FB );
    
    ISPAUSED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ISPAUSED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISPAUSED_FB__DigitalOutput__, ISPAUSED_FB );
    
    ISBUFFERING_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ISBUFFERING_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISBUFFERING_FB__DigitalOutput__, ISBUFFERING_FB );
    
    ISIDLE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ISIDLE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISIDLE_FB__DigitalOutput__, ISIDLE_FB );
    
    NEXTTRACKAVAILABLE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NEXTTRACKAVAILABLE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEXTTRACKAVAILABLE_FB__DigitalOutput__, NEXTTRACKAVAILABLE_FB );
    
    PREVIOUSTRACKAVAILABLE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PREVIOUSTRACKAVAILABLE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PREVIOUSTRACKAVAILABLE_FB__DigitalOutput__, PREVIOUSTRACKAVAILABLE_FB );
    
    SHOWPROGRESS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWPROGRESS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWPROGRESS_FB__DigitalOutput__, SHOWPROGRESS_FB );
    
    REPEATALLAVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( REPEATALLAVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( REPEATALLAVAILABLE__DigitalOutput__, REPEATALLAVAILABLE );
    
    REPEATONEAVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( REPEATONEAVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( REPEATONEAVAILABLE__DigitalOutput__, REPEATONEAVAILABLE );
    
    SHUFFLEAVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( SHUFFLEAVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHUFFLEAVAILABLE__DigitalOutput__, SHUFFLEAVAILABLE );
    
    SHUFFLEISON = new Crestron.Logos.SplusObjects.DigitalOutput( SHUFFLEISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHUFFLEISON__DigitalOutput__, SHUFFLEISON );
    
    PLAYERVOLUMEISMUTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PLAYERVOLUMEISMUTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PLAYERVOLUMEISMUTED_FB__DigitalOutput__, PLAYERVOLUMEISMUTED_FB );
    
    PLAYERVOLUMEISFIXED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PLAYERVOLUMEISFIXED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PLAYERVOLUMEISFIXED_FB__DigitalOutput__, PLAYERVOLUMEISFIXED_FB );
    
    GROUPVOLUMEISMUTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPVOLUMEISMUTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUPVOLUMEISMUTED_FB__DigitalOutput__, GROUPVOLUMEISMUTED_FB );
    
    GROUPVOLUMEISFIXED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPVOLUMEISFIXED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUPVOLUMEISFIXED_FB__DigitalOutput__, GROUPVOLUMEISFIXED_FB );
    
    PLAYERVOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogInput( PLAYERVOLUMELEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PLAYERVOLUMELEVEL__AnalogSerialInput__, PLAYERVOLUMELEVEL );
    
    PLAYERVOLUMELEVELBAR = new Crestron.Logos.SplusObjects.AnalogInput( PLAYERVOLUMELEVELBAR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PLAYERVOLUMELEVELBAR__AnalogSerialInput__, PLAYERVOLUMELEVELBAR );
    
    GROUPVOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogInput( GROUPVOLUMELEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GROUPVOLUMELEVEL__AnalogSerialInput__, GROUPVOLUMELEVEL );
    
    GROUPVOLUMELEVELBAR = new Crestron.Logos.SplusObjects.AnalogInput( GROUPVOLUMELEVELBAR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GROUPVOLUMELEVELBAR__AnalogSerialInput__, GROUPVOLUMELEVELBAR );
    
    FAVORITESELECT = new Crestron.Logos.SplusObjects.AnalogInput( FAVORITESELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FAVORITESELECT__AnalogSerialInput__, FAVORITESELECT );
    
    PLAYERVOLUME_LEVEL_FB = new Crestron.Logos.SplusObjects.AnalogOutput( PLAYERVOLUME_LEVEL_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PLAYERVOLUME_LEVEL_FB__AnalogSerialOutput__, PLAYERVOLUME_LEVEL_FB );
    
    PLAYERVOLUME_LEVEL_BAR_FB = new Crestron.Logos.SplusObjects.AnalogOutput( PLAYERVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PLAYERVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__, PLAYERVOLUME_LEVEL_BAR_FB );
    
    GROUPVOLUME_LEVEL_FB = new Crestron.Logos.SplusObjects.AnalogOutput( GROUPVOLUME_LEVEL_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GROUPVOLUME_LEVEL_FB__AnalogSerialOutput__, GROUPVOLUME_LEVEL_FB );
    
    GROUPVOLUME_LEVEL_BAR_FB = new Crestron.Logos.SplusObjects.AnalogOutput( GROUPVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GROUPVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__, GROUPVOLUME_LEVEL_BAR_FB );
    
    NOWPLAYINGLENGTHSECONDS = new Crestron.Logos.SplusObjects.AnalogOutput( NOWPLAYINGLENGTHSECONDS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NOWPLAYINGLENGTHSECONDS__AnalogSerialOutput__, NOWPLAYINGLENGTHSECONDS );
    
    NOWPLAYINGPOSITIONSECONDS = new Crestron.Logos.SplusObjects.AnalogOutput( NOWPLAYINGPOSITIONSECONDS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NOWPLAYINGPOSITIONSECONDS__AnalogSerialOutput__, NOWPLAYINGPOSITIONSECONDS );
    
    NOWPLAYINGPOSITIONGAUGE = new Crestron.Logos.SplusObjects.AnalogOutput( NOWPLAYINGPOSITIONGAUGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NOWPLAYINGPOSITIONGAUGE__AnalogSerialOutput__, NOWPLAYINGPOSITIONGAUGE );
    
    REPEATMODE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( REPEATMODE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( REPEATMODE_FB__AnalogSerialOutput__, REPEATMODE_FB );
    
    NUMBEROFFAVORITES = new Crestron.Logos.SplusObjects.AnalogOutput( NUMBEROFFAVORITES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMBEROFFAVORITES__AnalogSerialOutput__, NUMBEROFFAVORITES );
    
    SETSONOSZONENAME = new Crestron.Logos.SplusObjects.StringInput( SETSONOSZONENAME__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( SETSONOSZONENAME__AnalogSerialInput__, SETSONOSZONENAME );
    
    FAVORITENAMESELECT = new Crestron.Logos.SplusObjects.StringInput( FAVORITENAMESELECT__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FAVORITENAMESELECT__AnalogSerialInput__, FAVORITENAMESELECT );
    
    FROM_MEDIA_PLAYER = new Crestron.Logos.SplusObjects.StringInput( FROM_MEDIA_PLAYER__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_MEDIA_PLAYER__AnalogSerialInput__, FROM_MEDIA_PLAYER );
    
    NOWPLAYINGCONTAINERNAME = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGCONTAINERNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGCONTAINERNAME__AnalogSerialOutput__, NOWPLAYINGCONTAINERNAME );
    
    NOWPLAYINGTRACKNAME = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGTRACKNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGTRACKNAME__AnalogSerialOutput__, NOWPLAYINGTRACKNAME );
    
    NOWPLAYINGARTIST = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGARTIST__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGARTIST__AnalogSerialOutput__, NOWPLAYINGARTIST );
    
    NOWPLAYINGALBUM = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGALBUM__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGALBUM__AnalogSerialOutput__, NOWPLAYINGALBUM );
    
    NOWPLAYINGSTREAMINFO = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGSTREAMINFO__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGSTREAMINFO__AnalogSerialOutput__, NOWPLAYINGSTREAMINFO );
    
    NOWPLAYINGIMAGEURL = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGIMAGEURL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGIMAGEURL__AnalogSerialOutput__, NOWPLAYINGIMAGEURL );
    
    NOWPLAYINGLENGTHSECONDS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGLENGTHSECONDS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGLENGTHSECONDS__DOLLAR____AnalogSerialOutput__, NOWPLAYINGLENGTHSECONDS__DOLLAR__ );
    
    NOWPLAYINGPOSITIONSECONDS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGPOSITIONSECONDS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYINGPOSITIONSECONDS__DOLLAR____AnalogSerialOutput__, NOWPLAYINGPOSITIONSECONDS__DOLLAR__ );
    
    PLAYBACKERROR = new Crestron.Logos.SplusObjects.StringOutput( PLAYBACKERROR__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PLAYBACKERROR__AnalogSerialOutput__, PLAYBACKERROR );
    
    PLAYERNAME = new Crestron.Logos.SplusObjects.StringOutput( PLAYERNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PLAYERNAME__AnalogSerialOutput__, PLAYERNAME );
    
    GROUPNAME = new Crestron.Logos.SplusObjects.StringOutput( GROUPNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GROUPNAME__AnalogSerialOutput__, GROUPNAME );
    
    TO_MEDIA_PLAYER = new Crestron.Logos.SplusObjects.StringOutput( TO_MEDIA_PLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_MEDIA_PLAYER__AnalogSerialOutput__, TO_MEDIA_PLAYER );
    
    NOWPLAYINGINFO = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        NOWPLAYINGINFO[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGINFO__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NOWPLAYINGINFO__AnalogSerialOutput__ + i, NOWPLAYINGINFO[i+1] );
    }
    
    FAVORITESNAMES = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        FAVORITESNAMES[i+1] = new Crestron.Logos.SplusObjects.StringOutput( FAVORITESNAMES__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( FAVORITESNAMES__AnalogSerialOutput__ + i, FAVORITESNAMES[i+1] );
    }
    
    FAVORITESDESCRIPTIONS = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        FAVORITESDESCRIPTIONS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( FAVORITESDESCRIPTIONS__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( FAVORITESDESCRIPTIONS__AnalogSerialOutput__ + i, FAVORITESDESCRIPTIONS[i+1] );
    }
    
    FAVORITESIMAGEURLS = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        FAVORITESIMAGEURLS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( FAVORITESIMAGEURLS__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( FAVORITESIMAGEURLS__AnalogSerialOutput__ + i, FAVORITESIMAGEURLS[i+1] );
    }
    
    
    PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAY_OnPush_0, false ) );
    PAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAUSE_OnPush_1, false ) );
    TOGGLEPLAYPAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLEPLAYPAUSE_OnPush_2, false ) );
    NEXTTRACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXTTRACK_OnPush_3, false ) );
    PREVIOUSTRACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREVIOUSTRACK_OnPush_4, false ) );
    TOGGLEREPEATMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLEREPEATMODE_OnPush_5, false ) );
    TOGGLESHUFFLEMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLESHUFFLEMODE_OnPush_6, false ) );
    SHUFFLEMODEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHUFFLEMODEON_OnPush_7, false ) );
    SHUFFLEMODEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHUFFLEMODEOFF_OnPush_8, false ) );
    for( uint i = 0; i < 3; i++ )
        SETREPEATMODE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SETREPEATMODE_OnPush_9, false ) );
        
    PLAYERVOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAYERVOLUMEUP_OnPush_10, false ) );
    PLAYERVOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAYERVOLUMEDOWN_OnPush_11, false ) );
    GROUPVOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( GROUPVOLUMEUP_OnPush_12, false ) );
    GROUPVOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( GROUPVOLUMEDOWN_OnPush_13, false ) );
    MUTEPLAYER.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEPLAYER_OnPush_14, false ) );
    UNMUTEPLAYER.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTEPLAYER_OnPush_15, false ) );
    TOGGLEPLAYERMUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLEPLAYERMUTE_OnPush_16, false ) );
    MUTEGROUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEGROUP_OnPush_17, false ) );
    UNMUTEGROUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTEGROUP_OnPush_18, false ) );
    TOGGLEGROUPMUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLEGROUPMUTE_OnPush_19, false ) );
    PLAYERVOLUMELEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( PLAYERVOLUMELEVEL_OnChange_20, true ) );
    PLAYERVOLUMELEVELBAR.OnAnalogChange.Add( new InputChangeHandlerWrapper( PLAYERVOLUMELEVELBAR_OnChange_21, true ) );
    GROUPVOLUMELEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( GROUPVOLUMELEVEL_OnChange_22, true ) );
    GROUPVOLUMELEVELBAR.OnAnalogChange.Add( new InputChangeHandlerWrapper( GROUPVOLUMELEVELBAR_OnChange_23, true ) );
    FAVORITESELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( FAVORITESELECT_OnChange_24, true ) );
    FAVORITENAMESELECT.OnSerialChange.Add( new InputChangeHandlerWrapper( FAVORITENAMESELECT_OnChange_25, true ) );
    SETSONOSZONENAME.OnSerialChange.Add( new InputChangeHandlerWrapper( SETSONOSZONENAME_OnChange_26, false ) );
    FROM_MEDIA_PLAYER.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MEDIA_PLAYER_OnChange_27, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPDEVICEUI  = new SonosLibrary_v3_0.SimplPlusInterfaces.MediaPlayerDeviceSimplPlusInterface();
    
    
}

public CrestronModuleClass_SONOS_DEVICE_ENGINE_V3_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PLAY__DigitalInput__ = 0;
const uint PAUSE__DigitalInput__ = 1;
const uint TOGGLEPLAYPAUSE__DigitalInput__ = 2;
const uint NEXTTRACK__DigitalInput__ = 3;
const uint PREVIOUSTRACK__DigitalInput__ = 4;
const uint PLAYERVOLUMEUP__DigitalInput__ = 5;
const uint PLAYERVOLUMEDOWN__DigitalInput__ = 6;
const uint GROUPVOLUMEUP__DigitalInput__ = 7;
const uint GROUPVOLUMEDOWN__DigitalInput__ = 8;
const uint MUTEPLAYER__DigitalInput__ = 9;
const uint UNMUTEPLAYER__DigitalInput__ = 10;
const uint TOGGLEPLAYERMUTE__DigitalInput__ = 11;
const uint MUTEGROUP__DigitalInput__ = 12;
const uint UNMUTEGROUP__DigitalInput__ = 13;
const uint TOGGLEGROUPMUTE__DigitalInput__ = 14;
const uint TOGGLEREPEATMODE__DigitalInput__ = 15;
const uint TOGGLESHUFFLEMODE__DigitalInput__ = 16;
const uint SHUFFLEMODEON__DigitalInput__ = 17;
const uint SHUFFLEMODEOFF__DigitalInput__ = 18;
const uint SETREPEATMODE__DigitalInput__ = 19;
const uint PLAYERVOLUMELEVEL__AnalogSerialInput__ = 0;
const uint PLAYERVOLUMELEVELBAR__AnalogSerialInput__ = 1;
const uint GROUPVOLUMELEVEL__AnalogSerialInput__ = 2;
const uint GROUPVOLUMELEVELBAR__AnalogSerialInput__ = 3;
const uint FAVORITESELECT__AnalogSerialInput__ = 4;
const uint SETSONOSZONENAME__AnalogSerialInput__ = 5;
const uint FAVORITENAMESELECT__AnalogSerialInput__ = 6;
const uint FROM_MEDIA_PLAYER__AnalogSerialInput__ = 7;
const uint OFFLINE__DigitalOutput__ = 0;
const uint BUSY_FB__DigitalOutput__ = 1;
const uint DISCOVERINGGROUPS_FB__DigitalOutput__ = 2;
const uint GETTINGFAVORITES_FB__DigitalOutput__ = 3;
const uint ISGROUPED_FB__DigitalOutput__ = 4;
const uint ISPLAYING_FB__DigitalOutput__ = 5;
const uint ISPAUSED_FB__DigitalOutput__ = 6;
const uint ISBUFFERING_FB__DigitalOutput__ = 7;
const uint ISIDLE_FB__DigitalOutput__ = 8;
const uint NEXTTRACKAVAILABLE_FB__DigitalOutput__ = 9;
const uint PREVIOUSTRACKAVAILABLE_FB__DigitalOutput__ = 10;
const uint SHOWPROGRESS_FB__DigitalOutput__ = 11;
const uint REPEATALLAVAILABLE__DigitalOutput__ = 12;
const uint REPEATONEAVAILABLE__DigitalOutput__ = 13;
const uint SHUFFLEAVAILABLE__DigitalOutput__ = 14;
const uint SHUFFLEISON__DigitalOutput__ = 15;
const uint PLAYERVOLUMEISMUTED_FB__DigitalOutput__ = 16;
const uint PLAYERVOLUMEISFIXED_FB__DigitalOutput__ = 17;
const uint GROUPVOLUMEISMUTED_FB__DigitalOutput__ = 18;
const uint GROUPVOLUMEISFIXED_FB__DigitalOutput__ = 19;
const uint PLAYERVOLUME_LEVEL_FB__AnalogSerialOutput__ = 0;
const uint PLAYERVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__ = 1;
const uint GROUPVOLUME_LEVEL_FB__AnalogSerialOutput__ = 2;
const uint GROUPVOLUME_LEVEL_BAR_FB__AnalogSerialOutput__ = 3;
const uint NOWPLAYINGLENGTHSECONDS__AnalogSerialOutput__ = 4;
const uint NOWPLAYINGPOSITIONSECONDS__AnalogSerialOutput__ = 5;
const uint NOWPLAYINGPOSITIONGAUGE__AnalogSerialOutput__ = 6;
const uint REPEATMODE_FB__AnalogSerialOutput__ = 7;
const uint NUMBEROFFAVORITES__AnalogSerialOutput__ = 8;
const uint NOWPLAYINGCONTAINERNAME__AnalogSerialOutput__ = 9;
const uint NOWPLAYINGTRACKNAME__AnalogSerialOutput__ = 10;
const uint NOWPLAYINGARTIST__AnalogSerialOutput__ = 11;
const uint NOWPLAYINGALBUM__AnalogSerialOutput__ = 12;
const uint NOWPLAYINGSTREAMINFO__AnalogSerialOutput__ = 13;
const uint NOWPLAYINGIMAGEURL__AnalogSerialOutput__ = 14;
const uint NOWPLAYINGLENGTHSECONDS__DOLLAR____AnalogSerialOutput__ = 15;
const uint NOWPLAYINGPOSITIONSECONDS__DOLLAR____AnalogSerialOutput__ = 16;
const uint PLAYBACKERROR__AnalogSerialOutput__ = 17;
const uint PLAYERNAME__AnalogSerialOutput__ = 18;
const uint GROUPNAME__AnalogSerialOutput__ = 19;
const uint TO_MEDIA_PLAYER__AnalogSerialOutput__ = 20;
const uint NOWPLAYINGINFO__AnalogSerialOutput__ = 21;
const uint FAVORITESNAMES__AnalogSerialOutput__ = 26;
const uint FAVORITESDESCRIPTIONS__AnalogSerialOutput__ = 56;
const uint FAVORITESIMAGEURLS__AnalogSerialOutput__ = 86;

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
