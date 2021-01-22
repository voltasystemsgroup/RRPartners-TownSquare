namespace Passwords;
        // class declarations
         class Core;
         class UserData;
     class Core 
    {
        // class delegates
        delegate FUNCTION PasswordStatus ( SIMPLSHARPSTRING Status );
        delegate FUNCTION PasswordError ( SIMPLSHARPSTRING Error );

        // class events

        // class functions
        FUNCTION SavePass ( INTEGER UID , STRING Password );
        FUNCTION SetTimeout ( INTEGER delay );
        FUNCTION CompairPass ( STRING Password );
        FUNCTION LoadFile ();
        FUNCTION ErrorReport ( STRING error );
        FUNCTION XML_Save_Request ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty PasswordStatus StatusState;
        DelegateProperty PasswordError PasswordErrorState;
    };

     class UserData 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER UserID;
        STRING Password[];
    };

namespace MD5alt;
        // class declarations
         class MD5;
         class MD5InitializerConstant;
         class Digest;
         class MD5Helper;
         class MD5ChangingEventArgs;
         class MD5ChangedEventArgs;
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

