namespace SS_RoviTVListings;
        // class declarations
         class RoviGlobal;
         class RoviXmlConnect;
         class ListEventArgs;
         class ListEvents;
         class RoviListings;
         class Provider;
         class Listing;
         class FavsListItem;
         class FavChangeEventArgs;
         class FavCmds;
     class RoviGlobal 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION LogEvent ( STRING msg , LONG_INTEGER lvl );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING MusicCallSigns[][];
        static STRING MusicIconUrl[];
        static STRING BlankIconUrl[];

        // class properties
    };

     class RoviXmlConnect 
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

     class ListEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING providerID[];

        // class properties
    };

    static class ListEvents 
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

     class RoviListings 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetProviderID ( STRING ID );
        FUNCTION SetApiKey ( STRING ID );
        STRING_FUNCTION GetProviderID ();
        FUNCTION GetProviders ( STRING optZipcode );
        FUNCTION GetListings ();
        SIGNED_LONG_INTEGER_FUNCTION GetMLXMatch ( STRING ImageTitle );
        STRING_FUNCTION LogoName ( STRING url );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING CustURLPrefix[];

        // class properties
    };

     class Provider 
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
        STRING ServiceID[];
        STRING Type[];
        STRING MSOID[];
        STRING SystemName[];
    };

     class Listing 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Channel[];
        STRING DisplayName[];
        STRING AltDisplayName[];
        STRING ImageUrl[];
        STRING ImageWidth[];
        STRING ImageHeight[];
        STRING ImageType[];
        SIGNED_LONG_INTEGER MLXImageID;
        STRING CallLetters[];
        STRING ObjectName[];
    };

     class FavsListItem 
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
        STRING Channel[];
        STRING ImageUrl[];
        SIGNED_LONG_INTEGER MLXImageID;
        SIGNED_LONG_INTEGER Position;
    };

     class FavChangeEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER ChanIndex;
        STRING ChanNum[];
        STRING ChanName[];
        STRING ChanURL[];
        INTEGER MLXImageID;

        // class properties
    };

     class FavCmds 
    {
        // class delegates

        // class events
        EventHandler updateFav ( FavCmds sender, FavChangeEventArgs e );
        EventHandler defaultFavsReq ( FavCmds sender, EventArgs e );

        // class functions
        FUNCTION SetFavID ( STRING ID );
        FUNCTION SetProviderID ( STRING ID );
        FUNCTION SetListing ( RoviListings rl );
        INTEGER_FUNCTION GetChanNum ( INTEGER pos );
        FUNCTION FavsUpdate ( INTEGER favNum , INTEGER favIndex );
        FUNCTION LoadXMLRequest ();
        FUNCTION SetDefault ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        FavsListItem favs[];
        INTEGER UpdaterConnected;

        // class properties
    };

