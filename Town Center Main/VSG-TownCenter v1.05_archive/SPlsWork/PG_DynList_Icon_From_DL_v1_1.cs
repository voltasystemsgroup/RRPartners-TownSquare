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

namespace UserModule_PG_DYNLIST_ICON_FROM_DL_V1_1
{
    public class UserModuleClass_PG_DYNLIST_ICON_FROM_DL_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> DYN_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> MLX_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUT;
        private void CHANGEDETECT (  SplusExecutionContext __context__, ushort I ) 
            { 
            ushort C = 0;
            
            
            __context__.SourceCodeLine = 64;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( C  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (C  >= __FN_FORSTART_VAL__1) && (C  <= __FN_FOREND_VAL__1) ) : ( (C  <= __FN_FORSTART_VAL__1) && (C  >= __FN_FOREND_VAL__1) ) ; C  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 66;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IN[ I ] .UshortValue == DYN_IN[ C ] .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 68;
                    OUT [ I]  .Value = (ushort) ( MLX_IN[ C ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 69;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 64;
                } 
            
            
            }
            
        object IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 81;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 82;
                CHANGEDETECT (  __context__ , (ushort)( I )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        ushort I = 0;
        
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 94;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 95;
            Functions.Delay (  (int) ( 500 ) ) ; 
            __context__.SourceCodeLine = 96;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 98;
                CHANGEDETECT (  __context__ , (ushort)( I )) ; 
                __context__.SourceCodeLine = 96;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        IN = new InOutArray<AnalogInput>( 100, this );
        for( uint i = 0; i < 100; i++ )
        {
            IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( IN__AnalogSerialInput__ + i, IN__AnalogSerialInput__, this );
            m_AnalogInputList.Add( IN__AnalogSerialInput__ + i, IN[i+1] );
        }
        
        DYN_IN = new InOutArray<AnalogInput>( 100, this );
        for( uint i = 0; i < 100; i++ )
        {
            DYN_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( DYN_IN__AnalogSerialInput__ + i, DYN_IN__AnalogSerialInput__, this );
            m_AnalogInputList.Add( DYN_IN__AnalogSerialInput__ + i, DYN_IN[i+1] );
        }
        
        MLX_IN = new InOutArray<AnalogInput>( 100, this );
        for( uint i = 0; i < 100; i++ )
        {
            MLX_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( MLX_IN__AnalogSerialInput__ + i, MLX_IN__AnalogSerialInput__, this );
            m_AnalogInputList.Add( MLX_IN__AnalogSerialInput__ + i, MLX_IN[i+1] );
        }
        
        OUT = new InOutArray<AnalogOutput>( 100, this );
        for( uint i = 0; i < 100; i++ )
        {
            OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUT__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( OUT__AnalogSerialOutput__ + i, OUT[i+1] );
        }
        
        
        for( uint i = 0; i < 100; i++ )
            IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( IN_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PG_DYNLIST_ICON_FROM_DL_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint IN__AnalogSerialInput__ = 0;
    const uint DYN_IN__AnalogSerialInput__ = 100;
    const uint MLX_IN__AnalogSerialInput__ = 200;
    const uint OUT__AnalogSerialOutput__ = 0;
    
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
