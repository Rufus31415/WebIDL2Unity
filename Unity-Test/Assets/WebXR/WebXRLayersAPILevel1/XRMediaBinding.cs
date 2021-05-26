
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRMediaBinding : WebIDL2UnityObject {


    internal XRMediaBinding (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRMediaBinding_1(int session);

    public XRMediaBinding(XRSession session) : base(XRMediaBinding_1(session==null ? 0 : session.ID)) { }


    [DllImport("__Internal")]
    private static extern int XRMediaBinding_CreateQuadLayer(int id, int video, int init);

    public XRQuadLayer CreateQuadLayer(HTMLVideoElement video, XRMediaQuadLayerInit init) {
        var value = XRMediaBinding_CreateQuadLayer(this.ID, video==null ? 0 : video.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRQuadLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRMediaBinding_CreateCylinderLayer(int id, int video, int init);

    public XRCylinderLayer CreateCylinderLayer(HTMLVideoElement video, XRMediaCylinderLayerInit init) {
        var value = XRMediaBinding_CreateCylinderLayer(this.ID, video==null ? 0 : video.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XRCylinderLayer(value);
    }


    [DllImport("__Internal")]
    private static extern int XRMediaBinding_CreateEquirectLayer(int id, int video, int init);

    public XREquirectLayer CreateEquirectLayer(HTMLVideoElement video, XRMediaEquirectLayerInit init) {
        var value = XRMediaBinding_CreateEquirectLayer(this.ID, video==null ? 0 : video.ID, init==null ? 0 : init.ID);
        return value == 0 ? null : new XREquirectLayer(value);
    }
}
