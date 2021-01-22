namespace CoreHubEvents;
        // class declarations
         class PropertyTag;
         class CoreTag;
         class SystemCore;
         class EventTag;
         class HubEventArgs;
         class SingleHub;
     class PropertyTag 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING tagArea[];
        static STRING tagName[];
        static STRING tagAreaController[];
        static STRING tagStatus[];
        static STRING tagOrder[];
        static STRING tagLevel[];
        static STRING tagPosition[];
        static STRING tagHasLightsFlag[];
        static STRING tagHasShadesFlag[];
        static STRING tagHasDoorsFlag[];
        static STRING tagHasFireplFlag[];
        static STRING tagHasClimateFlag[];
        static STRING tagLightsID[];
        static STRING tagShadesID[];
        static STRING tagRegistered[];
        static STRING tagDimmable[];
        static STRING tagColorChange[];
        static STRING tagStarTwinkle[];
        static STRING tagStarDimm[];

        // class properties
    };

     class CoreTag 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING tagLight[];
        static STRING tagArea[];
        static STRING tagShade[];
        static STRING tagTP[];
        static STRING tagVantage[];

        // class properties
    };

     class SystemCore 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION FireHubCreation ( STRING _domain , SIGNED_LONG_INTEGER _id );
        static FUNCTION FireHubAreaCreationTimeout ();
        static FUNCTION FireXMLLightCreationTimeout ();
        static FUNCTION FireXMLShadeCreationTimeout ();
        static FUNCTION LogEvent ( STRING msg , LONG_INTEGER lvl );
        static FUNCTION SendEvent ( STRING _domain , HubEventArgs _lea );
        static SIGNED_LONG_INTEGER_FUNCTION GetAreaControllerId ( STRING _domain , SIGNED_LONG_INTEGER _areaId );
        static FUNCTION RegisterCore ( STRING _domain );
        static FUNCTION RemoveHub ( STRING _domain , SIGNED_LONG_INTEGER _id );
        static SIGNED_LONG_INTEGER_FUNCTION RegisterHub ( STRING _domain , SIGNED_LONG_INTEGER _id );
        static SIGNED_LONG_INTEGER_FUNCTION GetAreaSize ( STRING _domain );
        static FUNCTION PrintCore ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SetDebug;
    };

     class EventTag 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION getTagName ( SIGNED_LONG_INTEGER _tag );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static SIGNED_LONG_INTEGER tagRaise;
        static SIGNED_LONG_INTEGER tagLower;
        static SIGNED_LONG_INTEGER tagOn;
        static SIGNED_LONG_INTEGER tagOff;
        static SIGNED_LONG_INTEGER tagToggle;
        static SIGNED_LONG_INTEGER tagLevelSet;
        static SIGNED_LONG_INTEGER tagPreset;
        static SIGNED_LONG_INTEGER tagQuery;
        static SIGNED_LONG_INTEGER tagUpdate;
        static SIGNED_LONG_INTEGER tagNameChange;
        static SIGNED_LONG_INTEGER tagAreaStatus;
        static SIGNED_LONG_INTEGER tagAreaVC;
        static SIGNED_LONG_INTEGER tagXml;
        static SIGNED_LONG_INTEGER tagOpen;
        static SIGNED_LONG_INTEGER tagClose;
        static SIGNED_LONG_INTEGER tagStop;
        static SIGNED_LONG_INTEGER tagAreaController;
        static SIGNED_LONG_INTEGER tagPress;
        static SIGNED_LONG_INTEGER tagRelease;
        static SIGNED_LONG_INTEGER tagColorSet;
        static SIGNED_LONG_INTEGER tagStarTwinklePress;
        static SIGNED_LONG_INTEGER tagStarDimmPress;

        // class properties
    };

     class HubEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        INTEGER_FUNCTION ToUshort ( SIGNED_LONG_INTEGER num );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER requestTo;
        SIGNED_LONG_INTEGER requestBy;
        SIGNED_LONG_INTEGER etag;
        SIGNED_LONG_INTEGER etype;
        INTEGER Level;
        STRING DeviceName[];
        STRING Domain[];

        // class properties
    };

     class SingleHub 
    {
        // class delegates

        // class events
        EventHandler SingleHubChange ( SingleHub sender, HubEventArgs e );

        // class functions
        FUNCTION AddProperty ( STRING _key , STRING _value );
        STRING_FUNCTION GetProperty ( STRING _key );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

