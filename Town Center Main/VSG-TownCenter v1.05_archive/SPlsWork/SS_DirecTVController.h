namespace SS_DirecTVController;
        // class declarations
         class DTVChangeEventArgs;
         class Controller;
         class DTVTuned;
     class DTVChangeEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING ChanMajor[];
        STRING ChanMinor[];
        STRING IPAddress[];
        STRING MacAddress[];

        // class properties
    };

     class Controller 
    {
        // class delegates

        // class events
        static EventHandler DTVChanged ( DTVChangeEventArgs e );

        // class functions
        FUNCTION SendKey ( STRING cmd );
        FUNCTION SendKeyDown ( STRING cmd );
        FUNCTION SendKeyUp ( STRING cmd );
        FUNCTION FavTune ( SIGNED_LONG_INTEGER favMajor , SIGNED_LONG_INTEGER favMinor );
        FUNCTION GetTuned ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING IPAddress[];
        STRING MacAddress[];

        // class properties
    };

     class DTVTuned 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING callsign[];
        SIGNED_LONG_INTEGER major;
        SIGNED_LONG_INTEGER minor;
    };

