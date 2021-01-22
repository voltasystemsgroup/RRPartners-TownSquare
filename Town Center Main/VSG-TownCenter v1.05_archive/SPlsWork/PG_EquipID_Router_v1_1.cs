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

namespace UserModule_PG_EQUIPID_ROUTER_V1_1
{
    public class UserModuleClass_PG_EQUIPID_ROUTER_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SOURCE_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCE_REQ;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> OVERRIDE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> DEVICE_ID;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OVERRIDE_ID;
        Crestron.Logos.SplusObjects.AnalogOutput EQUIP_ID;
        private ushort CHECK_OVERRIDE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 68;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)5; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 69;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OVERRIDE[ I ] .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 70;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 68;
                } 
            
            __context__.SourceCodeLine = 72;
            return (ushort)( 0) ; 
            
            }
            
        object OVERRIDE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 78;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 79;
                EQUIP_ID  .Value = (ushort) ( OVERRIDE_ID[ I ] .UshortValue ) ; 
                
                
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
            
            
            __context__.SourceCodeLine = 86;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHECK_OVERRIDE( __context__ ) == 1))  ) ) 
                {
                __context__.SourceCodeLine = 87;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 89;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 90;
            EQUIP_ID  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 91;
            EQUIP_ID  .Value = (ushort) ( DEVICE_ID[ I ] .UshortValue ) ; 
            
            
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
        
        __context__.SourceCodeLine = 96;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHECK_OVERRIDE( __context__ ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 97;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 99;
        EQUIP_ID  .Value = (ushort) ( 800 ) ; 
        
        
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
    
    SOURCE_REQ = new InOutArray<DigitalInput>( 40, this );
    for( uint i = 0; i < 40; i++ )
    {
        SOURCE_REQ[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCE_REQ__DigitalInput__ + i, SOURCE_REQ__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCE_REQ__DigitalInput__ + i, SOURCE_REQ[i+1] );
    }
    
    OVERRIDE = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        OVERRIDE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( OVERRIDE__DigitalInput__ + i, OVERRIDE__DigitalInput__, this );
        m_DigitalInputList.Add( OVERRIDE__DigitalInput__ + i, OVERRIDE[i+1] );
    }
    
    DEVICE_ID = new InOutArray<AnalogInput>( 40, this );
    for( uint i = 0; i < 40; i++ )
    {
        DEVICE_ID[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( DEVICE_ID__AnalogSerialInput__ + i, DEVICE_ID[i+1] );
    }
    
    OVERRIDE_ID = new InOutArray<AnalogInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        OVERRIDE_ID[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OVERRIDE_ID__AnalogSerialInput__ + i, OVERRIDE_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( OVERRIDE_ID__AnalogSerialInput__ + i, OVERRIDE_ID[i+1] );
    }
    
    EQUIP_ID = new Crestron.Logos.SplusObjects.AnalogOutput( EQUIP_ID__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EQUIP_ID__AnalogSerialOutput__, EQUIP_ID );
    
    
    for( uint i = 0; i < 5; i++ )
        OVERRIDE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( OVERRIDE_OnPush_0, false ) );
        
    for( uint i = 0; i < 40; i++ )
        SOURCE_REQ[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCE_REQ_OnPush_1, false ) );
        
    SOURCE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCE_OFF_OnPush_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PG_EQUIPID_ROUTER_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SOURCE_OFF__DigitalInput__ = 0;
const uint SOURCE_REQ__DigitalInput__ = 1;
const uint OVERRIDE__DigitalInput__ = 41;
const uint DEVICE_ID__AnalogSerialInput__ = 0;
const uint OVERRIDE_ID__AnalogSerialInput__ = 40;
const uint EQUIP_ID__AnalogSerialOutput__ = 0;

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
