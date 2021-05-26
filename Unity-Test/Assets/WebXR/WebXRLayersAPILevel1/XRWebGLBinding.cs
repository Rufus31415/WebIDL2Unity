
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRWebGLBinding : WebIDL2UnityObject {


    internal XRWebGLBinding (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_2(int session, int context);

    public XRWebGLBinding(XRSession session, XRWebGLRenderingContext context) : base(XRWebGLBinding_2(session==null ? 0 : session.ID, context==null ? 0 : context.ID)) { }


    public double NativeProjectionScaleFactor {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "nativeProjectionScaleFactor");
            return value;
        }
    }



    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_CreateProjectionLayer(int id, int init);

    public XRProjectionLayer CreateProjectionLayer(XRProjectionLayerInit init) {
        var value = XRWebGLBinding_CreateProjectionLayer(this.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRProjectionLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_CreateQuadLayer(int id, int init);

    public XRQuadLayer CreateQuadLayer(XRQuadLayerInit init) {
        var value = XRWebGLBinding_CreateQuadLayer(this.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRQuadLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_CreateCylinderLayer(int id, int init);

    public XRCylinderLayer CreateCylinderLayer(XRCylinderLayerInit init) {
        var value = XRWebGLBinding_CreateCylinderLayer(this.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRCylinderLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_CreateEquirectLayer(int id, int init);

    public XREquirectLayer CreateEquirectLayer(XREquirectLayerInit init) {
        var value = XRWebGLBinding_CreateEquirectLayer(this.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XREquirectLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_CreateCubeLayer(int id, int init);

    public XRCubeLayer CreateCubeLayer(XRCubeLayerInit init) {
        var value = XRWebGLBinding_CreateCubeLayer(this.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRCubeLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_GetSubImage(int id, int layer, int frame, int eye);

    public XRWebGLSubImage GetSubImage(XRCompositionLayer layer, XRFrame frame, XREye eye) {
        var value = XRWebGLBinding_GetSubImage(this.ID, layer==null ? 0 : layer.ID, frame==null ? 0 : frame.ID, (int)eye);
        return value == 0 ? null : new XRWebGLSubImage(value);
    }


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_GetViewSubImage(int id, int layer, int view);

    public XRWebGLSubImage GetViewSubImage(XRProjectionLayer layer, XRView view) {
        var value = XRWebGLBinding_GetViewSubImage(this.ID, layer==null ? 0 : layer.ID, view==null ? 0 : view.ID);
        return value == 0 ? null : new XRWebGLSubImage(value);
    }
}
