namespace MD5alt;
        // class declarations
         class MD5InitializerConstant;
         class Digest;
         class MD5Helper;
         class MD5ChangingEventArgs;
         class MD5ChangedEventArgs;
         class MD5;
    static class MD5InitializerConstant // enum
    {
        static LONG_INTEGER D;
        static LONG_INTEGER A;
        static LONG_INTEGER C;
        static LONG_INTEGER B;
    };

     class Digest 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        LONG_INTEGER A;
        LONG_INTEGER B;
        LONG_INTEGER C;
        LONG_INTEGER D;

        // class properties
    };

     class MD5Helper 
    {
        // class delegates

        // class events

        // class functions
        static LONG_INTEGER_FUNCTION RotateLeft ( LONG_INTEGER uiNumber , INTEGER shift );
        static LONG_INTEGER_FUNCTION ReverseByte ( LONG_INTEGER uiNumber );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MD5 
    {
        // class delegates

        // class events
        EventHandler OnValueChanging ( MD5 sender, MD5ChangingEventArgs Changing );
        EventHandler OnValueChanged ( MD5 sender, MD5ChangedEventArgs Changed );

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Value[];
        STRING FingerPrint[];
    };

namespace XMLCommunicator;
        // class declarations
         class XMLCOMGENERICEVENT_Args;
         class ComEventGetListRxTxArgs;
         class LoadStruct;
         class RoomOptionStruct;
         class RoomStruct;
         class ProfileStruct;
         class ComEventArgs;
         class Communicator;
         class pg_crypto;
     class XMLCOMGENERICEVENT_Args 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER msgType;
        INTEGER index;
        STRING sValue[];
        INTEGER aValue;
        INTEGER dValue;

        // class properties
    };

     class ComEventGetListRxTxArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER TouchpanelId;
        SIGNED_LONG_INTEGER ListType;
        INTEGER RoomList[];
    };

     class LoadStruct 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER LoadID;
        INTEGER AreaID;
        STRING LoadName[];
    };

     class RoomOptionStruct 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Size;
    };

     class RoomStruct 
    {
        // class delegates

        // class events
        EventHandler EventRoomOptionTrigger ( RoomStruct sender, XMLCOMGENERICEVENT_Args e );
        EventHandler EventRoomOptionUpdate ( RoomStruct sender, XMLCOMGENERICEVENT_Args e );
        EventHandler EventRoomVolRaiseStart ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolRaiseEnd ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolLowerStart ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolLowerEnd ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolMute ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolChange ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomVolSet ( RoomStruct sender, XMLCOMGENERICEVENT_Args e );
        EventHandler EventRoomMuteChange ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomSrcChange ( RoomStruct sender, EventArgs e );
        EventHandler EventRoomNameChange ( RoomStruct sender, EventArgs e );

        // class functions
        STRING_FUNCTION ToString ();
        FUNCTION ResetActiveSrc ( INTEGER resetSrcValue );
        FUNCTION FireRoomVolRaiseStart ();
        FUNCTION FireRoomVolRaiseEnd ();
        FUNCTION FireRoomVolLowerStart ();
        FUNCTION FireRoomVolLowerEnd ();
        FUNCTION FireRoomVolMute ();
        FUNCTION FireRoomVolChange ();
        FUNCTION FireRoomVolSet ( INTEGER level );
        FUNCTION FireRoomMuteChange ();
        FUNCTION FireRoomNameChange ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING RoomName[];
        INTEGER RoomOrder;
        INTEGER RoomID;
        INTEGER SourcesIDsAvail[];
        INTEGER ActiveSRC;
        INTEGER LightsID;
        INTEGER ThermoID;
        INTEGER ShadesID;
        INTEGER DoorsID;
        INTEGER FireID;
        INTEGER RoomState;
        INTEGER MuteState;
        INTEGER VolLevel;
        RoomOptionStruct RoomOptions;
        INTEGER Floor;
    };

     class ProfileStruct 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        INTEGER ID;
        INTEGER VisibleRMs[];
        INTEGER VisibleLightAreas[];
        INTEGER VisibleLightLoads[];
        INTEGER VisibleClimate[];
        INTEGER VisibleShadesAreas[];
        INTEGER VisibleShadesLoads[];
        INTEGER VisibleDoor[];
        INTEGER VisibleFire[];
        INTEGER RMEditorList[];
    };

     class Communicator 
    {
        // class delegates

        // class events

        // class functions
        static INTEGER_FUNCTION ComGetTpProfile ( INTEGER _tpId );
        FUNCTION SetJobName ( STRING name );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING JobName[];
        STRING RefMethodGetList[];
        STRING RefMethodGetTpProfile[];
    };

     class pg_crypto 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ErrorReport ( STRING error );
        FUNCTION ErrorTicket ( STRING error );
        FUNCTION CheckModules ( STRING key );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

