namespace SS_ShadingController;
        // class declarations
         class SimplPlusDataArgs;
         class ShadingActionList;
         class ShadingActionList_Levels;
         class SALEventArgs;
         class ShadingController;
         class AreaEquipment;
         class ShadingController_ListLevels;
         class ShadingEquipment;
         class ButtonPressHandler;
         class ShadingXMLConnect;
     class SimplPlusDataArgs 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION ConvertToUshort ( SIGNED_LONG_INTEGER _num );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER sigDigital;
        INTEGER sigAnalog;
        STRING sigSerial[];
        SIGNED_LONG_INTEGER flagTag;

        // class properties
    };

     class ShadingActionList 
    {
        // class delegates

        // class events
        EventHandler updateName ( ShadingActionList sender, SALEventArgs e );
        EventHandler updateState ( ShadingActionList sender, SALEventArgs e );
        EventHandler updateAllStates ( ShadingActionList sender, SALEventArgs e );
        EventHandler updateIcon ( ShadingActionList sender, SALEventArgs e );
        EventHandler updateLastSelected ( ShadingActionList sender, SALEventArgs e );
        EventHandler updateListSize ( ShadingActionList sender, SALEventArgs e );

        // class functions
        FUNCTION AreaIDLookup ( INTEGER id );
        FUNCTION GetShadeRooms ();
        INTEGER_FUNCTION changeRoomReq ( INTEGER listIndex );
        INTEGER_FUNCTION changeRoom ( INTEGER listIndex );
        FUNCTION changeAll ( INTEGER state );
        FUNCTION pressOpen ();
        FUNCTION pressClose ();
        FUNCTION pressStop ();
        FUNCTION pressPreset ( INTEGER presetNum );
        FUNCTION startRaise ();
        FUNCTION endRaise ();
        FUNCTION raiseSingle ();
        FUNCTION startLower ();
        FUNCTION endLower ();
        FUNCTION lowerSingle ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER TouchpanelID;
        INTEGER ActionListActive;

        // class properties
    };

     class ShadingActionList_Levels 
    {
        // class delegates

        // class events
        EventHandler updateLevel ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateMasterLevel ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateName ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateState ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateAllStates ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateIcon ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateLastSelected ( ShadingActionList_Levels sender, SALEventArgs e );
        EventHandler updateListSize ( ShadingActionList_Levels sender, SALEventArgs e );

        // class functions
        FUNCTION setMasterLevel ( INTEGER level );
        FUNCTION setAreaLevel ( INTEGER pos , INTEGER level );
        FUNCTION SendAreaOpenRaisePress ( INTEGER pos );
        FUNCTION SendAreaOpenRaiseRelease ();
        FUNCTION SendAreaRaiseSinglePress ( INTEGER pos );
        FUNCTION SendAreaRaiseSingleRelease ();
        FUNCTION SendAreaCloseLowerPress ( INTEGER pos );
        FUNCTION SendAreaCloseLowerRelease ();
        FUNCTION SendAreaLowerSinglePress ( INTEGER pos );
        FUNCTION SendAreaLowerSingleRelease ();
        FUNCTION SendGroupOpenRaisePress ();
        FUNCTION SendGroupOpenRaiseRelease ();
        FUNCTION SendGroupRaiseSinglePress ();
        FUNCTION SendGroupRaiseSingleRelease ();
        FUNCTION SendGroupCloseLowerPress ();
        FUNCTION SendGroupCloseLowerRelease ();
        FUNCTION SendGroupLowerSinglePress ();
        FUNCTION SendGroupLowerSingleRelease ();
        FUNCTION StartAreaRaise ( INTEGER pos );
        FUNCTION EndAreaRaise ( INTEGER pos );
        FUNCTION AreaRaiseSingle ( INTEGER pos );
        FUNCTION StartAreaLower ( INTEGER pos );
        FUNCTION EndAreaLower ( INTEGER pos );
        FUNCTION AreaLowerSingle ( INTEGER pos );
        FUNCTION SendAreaOpen ( INTEGER pos );
        FUNCTION SendAreaClose ( INTEGER pos );
        FUNCTION AreaToggle ( INTEGER pos );
        FUNCTION AreaIDLookup ( INTEGER id );
        FUNCTION GetShadeRooms ();
        INTEGER_FUNCTION changeRoomReq ( INTEGER listIndex );
        INTEGER_FUNCTION changeRoom ( INTEGER listIndex );
        FUNCTION changeAll ( INTEGER state );
        FUNCTION pressOpen ();
        FUNCTION pressClose ();
        FUNCTION pressStop ();
        FUNCTION pressPreset ( INTEGER presetNum );
        FUNCTION startRaise ();
        FUNCTION endRaise ();
        FUNCTION raiseSingle ();
        FUNCTION startLower ();
        FUNCTION endLower ();
        FUNCTION lowerSingle ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER TouchpanelID;
        INTEGER ActionListActive;

        // class properties
        INTEGER MasterAverage;
    };

     class SALEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING argString[];
        INTEGER argIndex;
        INTEGER argAnalog;

        // class properties
    };

     class ShadingController 
    {
        // class delegates

        // class events
        EventHandler updateName ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updateLevel ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updateFeedback ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updatePreset ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updateArea ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updateAreaFeedback ( ShadingController sender, SimplPlusDataArgs e );
        EventHandler updateAreaName ( ShadingController sender, SimplPlusDataArgs e );

        // class functions
        static SIGNED_LONG_INTEGER_FUNCTION GetAvailableTpId ();
        FUNCTION SetupController ();
        FUNCTION Query ();
        FUNCTION QueryAreaLoads ();
        FUNCTION Update ( INTEGER _level , STRING _name );
        FUNCTION Trigger ( INTEGER _tag , INTEGER _type );
        FUNCTION SendOpen ();
        FUNCTION SendClose ();
        FUNCTION SendStop ();
        FUNCTION Toggle ();
        FUNCTION SetLevel ( INTEGER _level );
        FUNCTION StartRaise ();
        FUNCTION EndRaise ();
        FUNCTION RaiseSingle ();
        FUNCTION StartLower ();
        FUNCTION EndLower ();
        FUNCTION LowerSingle ();
        FUNCTION Preset ( INTEGER _num );
        FUNCTION AreaOpen ();
        FUNCTION AreaClose ();
        FUNCTION AreaStop ();
        FUNCTION AreaToggle ();
        FUNCTION AreaSetLevel ( INTEGER _level );
        FUNCTION AreaStartRaise ();
        FUNCTION AreaEndRaise ();
        FUNCTION AreaRaiseSingle ();
        FUNCTION AreaStartLower ();
        FUNCTION AreaEndLower ();
        FUNCTION AreaLowerSingle ();
        FUNCTION AreaPreset ( INTEGER _num );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER TouchpanelID;
        SIGNED_LONG_INTEGER ControllerAreaSize;

        // class properties
        SIGNED_LONG_INTEGER ControllerId;
        SIGNED_LONG_INTEGER ControllerAreaId;
        INTEGER ControllerListModeActive;
        SIGNED_LONG_INTEGER ControllerActiveListItem;
        INTEGER ControllerActive;
    };

     class ShadingController_ListLevels 
    {
        // class delegates

        // class events
        EventHandler updateAreaLevel ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateName ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateLevel ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateFeedback ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updatePreset ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateArea ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateAreaFeedback ( ShadingController_ListLevels sender, SimplPlusDataArgs e );
        EventHandler updateAreaName ( ShadingController_ListLevels sender, SimplPlusDataArgs e );

        // class functions
        FUNCTION SendOpenRaisePress ();
        FUNCTION SendOpenRaiseRelease ();
        FUNCTION SendRaiseSinglePress ();
        FUNCTION SendRaiseSingleRelease ();
        FUNCTION SendCloseLowerPress ();
        FUNCTION SendCloseLowerRelease ();
        FUNCTION SendLowerSinglePress ();
        FUNCTION SendLowerSingleRelease ();
        FUNCTION SendAreaOpenRaisePress ();
        FUNCTION SendAreaOpenRaiseRelease ();
        FUNCTION SendAreaRaiseSinglePress ();
        FUNCTION SendAreaRaiseSingleRelease ();
        FUNCTION SendAreaCloseLowerPress ();
        FUNCTION SendAreaCloseLowerRelease ();
        FUNCTION SendAreaLowerSinglePress ();
        FUNCTION SendAreaLowerSingleRelease ();
        FUNCTION SetupController ();
        FUNCTION Query ();
        FUNCTION QueryAreaLoads ();
        FUNCTION Update ( INTEGER _level , STRING _name );
        FUNCTION Trigger ( INTEGER _tag , INTEGER _type );
        FUNCTION SendOpen ();
        FUNCTION SendClose ();
        FUNCTION SendStop ();
        FUNCTION Toggle ();
        FUNCTION SetLevel ( INTEGER _level );
        FUNCTION StartRaise ();
        FUNCTION EndRaise ();
        FUNCTION RaiseSingle ();
        FUNCTION StartLower ();
        FUNCTION EndLower ();
        FUNCTION LowerSingle ();
        FUNCTION Preset ( INTEGER _num );
        FUNCTION AreaOpen ();
        FUNCTION AreaClose ();
        FUNCTION AreaStop ();
        FUNCTION AreaToggle ();
        FUNCTION AreaSetLevel ( INTEGER _level );
        FUNCTION AreaStartRaise ();
        FUNCTION AreaEndRaise ();
        FUNCTION AreaRaiseSingle ();
        FUNCTION AreaStartLower ();
        FUNCTION AreaEndLower ();
        FUNCTION AreaLowerSingle ();
        FUNCTION AreaPreset ( INTEGER _num );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER TouchpanelID;
        SIGNED_LONG_INTEGER ControllerAreaSize;

        // class properties
        INTEGER AreaAverage;
        SIGNED_LONG_INTEGER ControllerId;
        SIGNED_LONG_INTEGER ControllerAreaId;
        INTEGER ControllerListModeActive;
        SIGNED_LONG_INTEGER ControllerActiveListItem;
        INTEGER ControllerActive;
    };

     class ShadingEquipment 
    {
        // class delegates

        // class events
        EventHandler triggerOpen ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerClose ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerStop ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerToggle ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerRaiseStart ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerRaisePulse ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerRaiseEnd ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerLowerStart ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerLowerPulse ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerLowerEnd ( ShadingEquipment sender, EventArgs e );
        EventHandler triggerLevelSet ( ShadingEquipment sender, SimplPlusDataArgs e );
        EventHandler triggerPreset ( ShadingEquipment sender, SimplPlusDataArgs e );
        EventHandler reqCurrentAreaName ( ShadingEquipment sender, EventArgs e );
        EventHandler reqCurrentConfig ( ShadingEquipment sender, EventArgs e );

        // class functions
        FUNCTION ManualToggle ();
        FUNCTION EquipInit ();
        FUNCTION SendQueryResponse ( SIGNED_LONG_INTEGER to , SIGNED_LONG_INTEGER etag , SIGNED_LONG_INTEGER etype );
        FUNCTION BroadCast ( SIGNED_LONG_INTEGER _etag , SIGNED_LONG_INTEGER _etype );
        FUNCTION SetupDevice ( SIGNED_LONG_INTEGER _shadeId , INTEGER _areaId , STRING _name , INTEGER _discreteToggle );
        FUNCTION SetupArea ( INTEGER _areaId , STRING _name , INTEGER _discreteToggle );
        FUNCTION AtPreset ( INTEGER _num , INTEGER _status );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DeviceID;
        SIGNED_LONG_INTEGER AreaID;
        STRING AreaName[];
        STRING DeviceName[];
        INTEGER DeviceLevel;
        INTEGER DeviceStatus;
        INTEGER DeviceMoving;
        INTEGER DiscreteToggle;
    };

     class ShadingXMLConnect 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

