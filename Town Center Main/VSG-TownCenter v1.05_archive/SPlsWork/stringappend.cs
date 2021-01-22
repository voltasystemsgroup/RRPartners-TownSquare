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

namespace UserModule_STRINGAPPEND
{
    public class UserModuleClass_STRINGAPPEND : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput STRING1;
        Crestron.Logos.SplusObjects.StringInput STRING2;
        Crestron.Logos.SplusObjects.StringInput STRING3;
        Crestron.Logos.SplusObjects.StringInput STRING4;
        Crestron.Logos.SplusObjects.StringOutput FULLSTRING1;
        Crestron.Logos.SplusObjects.StringOutput FULLSTRING2;
        Crestron.Logos.SplusObjects.StringOutput FULLSTRING3;
        Crestron.Logos.SplusObjects.StringOutput FULLSTRING4;
        StringParameter APPENDTEXT;
        object STRING1_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 98;
                MakeString ( FULLSTRING1 , "{0}{1}", STRING1 , APPENDTEXT ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STRING2_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 102;
            MakeString ( FULLSTRING2 , "{0}{1}", STRING2 , APPENDTEXT ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STRING3_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 106;
        MakeString ( FULLSTRING3 , "{0}{1}", STRING3 , APPENDTEXT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STRING4_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 110;
        MakeString ( FULLSTRING4 , "{0}{1}", STRING4 , APPENDTEXT ) ; 
        
        
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
        
        __context__.SourceCodeLine = 121;
        MakeString ( FULLSTRING1 , "{0}{1}", STRING1 , APPENDTEXT ) ; 
        __context__.SourceCodeLine = 122;
        MakeString ( FULLSTRING2 , "{0}{1}", STRING2 , APPENDTEXT ) ; 
        __context__.SourceCodeLine = 123;
        MakeString ( FULLSTRING3 , "{0}{1}", STRING3 , APPENDTEXT ) ; 
        __context__.SourceCodeLine = 124;
        MakeString ( FULLSTRING4 , "{0}{1}", STRING4 , APPENDTEXT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    STRING1 = new Crestron.Logos.SplusObjects.StringInput( STRING1__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( STRING1__AnalogSerialInput__, STRING1 );
    
    STRING2 = new Crestron.Logos.SplusObjects.StringInput( STRING2__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( STRING2__AnalogSerialInput__, STRING2 );
    
    STRING3 = new Crestron.Logos.SplusObjects.StringInput( STRING3__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( STRING3__AnalogSerialInput__, STRING3 );
    
    STRING4 = new Crestron.Logos.SplusObjects.StringInput( STRING4__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( STRING4__AnalogSerialInput__, STRING4 );
    
    FULLSTRING1 = new Crestron.Logos.SplusObjects.StringOutput( FULLSTRING1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FULLSTRING1__AnalogSerialOutput__, FULLSTRING1 );
    
    FULLSTRING2 = new Crestron.Logos.SplusObjects.StringOutput( FULLSTRING2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FULLSTRING2__AnalogSerialOutput__, FULLSTRING2 );
    
    FULLSTRING3 = new Crestron.Logos.SplusObjects.StringOutput( FULLSTRING3__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FULLSTRING3__AnalogSerialOutput__, FULLSTRING3 );
    
    FULLSTRING4 = new Crestron.Logos.SplusObjects.StringOutput( FULLSTRING4__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FULLSTRING4__AnalogSerialOutput__, FULLSTRING4 );
    
    APPENDTEXT = new StringParameter( APPENDTEXT__Parameter__, this );
    m_ParameterList.Add( APPENDTEXT__Parameter__, APPENDTEXT );
    
    
    STRING1.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING1_OnChange_0, false ) );
    STRING2.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING2_OnChange_1, false ) );
    STRING3.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING3_OnChange_2, false ) );
    STRING4.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING4_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_STRINGAPPEND ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint STRING1__AnalogSerialInput__ = 0;
const uint STRING2__AnalogSerialInput__ = 1;
const uint STRING3__AnalogSerialInput__ = 2;
const uint STRING4__AnalogSerialInput__ = 3;
const uint FULLSTRING1__AnalogSerialOutput__ = 0;
const uint FULLSTRING2__AnalogSerialOutput__ = 1;
const uint FULLSTRING3__AnalogSerialOutput__ = 2;
const uint FULLSTRING4__AnalogSerialOutput__ = 3;
const uint APPENDTEXT__Parameter__ = 10;

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
