/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class MsrpEvent : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MsrpEvent(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MsrpEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MsrpEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_MsrpEvent(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public tmsrp_event_type_t getType() {
    tmsrp_event_type_t ret = (tmsrp_event_type_t)tinyWRAPPINVOKE.MsrpEvent_getType(swigCPtr);
    return ret;
  }

  public MsrpSession getSipSession() {
    IntPtr cPtr = tinyWRAPPINVOKE.MsrpEvent_getSipSession(swigCPtr);
    MsrpSession ret = (cPtr == IntPtr.Zero) ? null : new MsrpSession(cPtr, false);
    return ret;
  }

  public MsrpMessage getMessage() {
    IntPtr cPtr = tinyWRAPPINVOKE.MsrpEvent_getMessage(swigCPtr);
    MsrpMessage ret = (cPtr == IntPtr.Zero) ? null : new MsrpMessage(cPtr, false);
    return ret;
  }

}

}