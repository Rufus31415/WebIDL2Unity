
using System;
using System.Runtime.InteropServices;

public partial  class XRSession : WebIDL2UnityObject {


    internal XRSession (int id) : base(id) {}


    public XRVisibilityState VisibilityState {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "visibilityState");
            return (XRVisibilityState)value;
        }
    }



    public XRRenderState RenderState {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "renderState");
            return value == 0 ? null : new XRRenderState(value);
        }
    }



    public XRInputSourceArray InputSources {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "inputSources");
            return value == 0 ? null : new XRInputSourceArray(value);
        }
    }








    public EventHandler Onend {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onend", value.ID);
        }
    }



    public EventHandler Oninputsourceschange {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "oninputsourceschange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "oninputsourceschange", value.ID);
        }
    }



    public EventHandler Onselect {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onselect");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onselect", value.ID);
        }
    }



    public EventHandler Onselectstart {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onselectstart");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onselectstart", value.ID);
        }
    }



    public EventHandler Onselectend {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onselectend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onselectend", value.ID);
        }
    }



    public EventHandler Onsqueeze {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onsqueeze");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onsqueeze", value.ID);
        }
    }



    public EventHandler Onsqueezestart {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onsqueezestart");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onsqueezestart", value.ID);
        }
    }



    public EventHandler Onsqueezeend {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onsqueezeend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onsqueezeend", value.ID);
        }
    }



    public EventHandler Onvisibilitychange {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onvisibilitychange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onvisibilitychange", value.ID);
        }
    }

}
