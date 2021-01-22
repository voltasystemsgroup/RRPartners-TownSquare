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

namespace UserModule_PG_EQUIPID_ROUTER_V1_2
{
    public class UserModuleClass_PG_EQUIPID_ROUTER_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput EQUIP_ID_IN;
        Crestron.Logos.SplusObjects.DigitalInput SOURCE_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCE_REQ;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> DEVICE_ID;
        Crestron.Logos.SplusObjects.AnalogOutput EQUIP_ID_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput SOURCE_OFF_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCE_FB;
        ushort CUR_EQUIP_ID = 0;
        private ushort FINDDEVICE (  SplusExecutionContext __context__, ushort ID ) 
            { 
            ushort I = 0;
            ushort NUM = 0;
            
            
            __context__.SourceCodeLine = 72;
            NUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ID == 0))  ) ) 
                {
                __context__.SourceCodeLine = 75;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 77;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)50; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 79;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ID == DEVICE_ID[ I ] .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 81;
                    NUM = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 82;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 77;
                } 
            
            __context__.SourceCodeLine = 86;
            return (ushort)( NUM) ; 
            
            }
            
        private void UPDATEFEEDBACK (  SplusExecutionContext __context__, ushort NUM ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NUM == 0))  ) ) 
                {
                __context__.SourceCodeLine = 94;
                return ; 
                }
            
            __context__.SourceCodeLine = 96;
            SOURCE_OFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 97;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)50; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 99;
                SOURCE_FB [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 97;
                } 
            
            __context__.SourceCodeLine = 101;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NUM == 800))  ) ) 
                { 
                __context__.SourceCodeLine = 103;
                SOURCE_OFF_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 105;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUM > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 107;
                    SOURCE_FB [ NUM]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            
            }
            
        object EQUIP_ID_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort NUM = 0;
                
                
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EQUIP_ID_IN  .UshortValue == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 117;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 118;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EQUIP_ID_IN  .UshortValue == CUR_EQUIP_ID))  ) ) 
                    {
                    __context__.SourceCodeLine = 119;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 122;
                NUM = (ushort) ( FINDDEVICE( __context__ , (ushort)( EQUIP_ID_IN  .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 123;
                UPDATEFEEDBACK (  __context__ , (ushort)( NUM )) ; 
                __context__.SourceCodeLine = 124;
                CUR_EQUIP_ID = (ushort) ( EQUIP_ID_IN  .UshortValue ) ; 
                __context__.SourceCodeLine = 125;
                EQUIP_ID_OUT  .Value = (ushort) ( EQUIP_ID_IN  .UshortValue ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SOURCE_REQ_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 131;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 132;
            CUR_EQUIP_ID = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 133;
            EQUIP_ID_OUT  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 134;
            CUR_EQUIP_ID = (ushort) ( DEVICE_ID[ I ] .UshortValue ) ; 
            __context__.SourceCodeLine = 135;
            EQUIP_ID_OUT  .Value = (ushort) ( DEVICE_ID[ I ] .UshortValue ) ; 
            __context__.SourceCodeLine = 136;
            UPDATEFEEDBACK (  __context__ , (ushort)( I )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SOURCE_OFF_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        CUR_EQUIP_ID = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 142;
        EQUIP_ID_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 143;
        CUR_EQUIP_ID = (ushort) ( 800 ) ; 
        __context__.SourceCodeLine = 144;
        EQUIP_ID_OUT  .Value = (ushort) ( 800 ) ; 
        __context__.SourceCodeLine = 145;
        UPDATEFEEDBACK (  __context__ , (ushort)( 800 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SOURCE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( SOURCE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( SOURCE_OFF__DigitalInput__, SOURCE_OFF );
    
    SOURCE_REQ = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SOURCE_REQ[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCE_REQ__DigitalInput__ + i, SOURCE_REQ__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCE_REQ__DigitalInput__ + i, SOURCE_REQ[i+1] );
    }
    
    SOURCE_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCE_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURCE_OFF_FB__DigitalOutput__, SOURCE_OFF_FB );
    
    SOURCE_FB = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SOURCE_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCE_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCE_FB__DigitalOutput__ + i, SOURCE_FB[i+1] );
    }
    
    EQUIP_ID_IN = new Crestron.Logos.SplusObjects.AnalogInput( EQUIP_ID_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( EQUIP_ID_IN__AnalogSerialInput__, EQUIP_ID_IN );
    
    DEVICE_ID = new InOutArray<AnalogInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        DEVICE_ID[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID[i+1] );
    }
    
    EQUIP_ID_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( EQUIP_ID_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EQUIP_ID_OUT__AnalogSerialOutput__, EQUIP_ID_OUT );
    
    
    EQUIP_ID_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( EQUIP_ID_IN_OnChange_0, false ) );
    for( uint i = 0; i < 50; i++ )
        SOURCE_REQ[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCE_REQ_OnPush_1, false ) );
        
    SOURCE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCE_OFF_OnPush_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PG_EQUIPID_ROUTER_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint EQUIP_ID_IN__AnalogSerialInput__ = 0;
const uint SOURCE_OFF__DigitalInput__ = 0;
const uint SOURCE_REQ__DigitalInput__ = 1;
const uint DEVICE_ID__AnalogSerialInput__ = 1;
const uint EQUIP_ID_OUT__AnalogSerialOutput__ = 0;
const uint SOURCE_OFF_FB__DigitalOutput__ = 0;
const uint SOURCE_FB__DigitalOutput__ = 1;

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
