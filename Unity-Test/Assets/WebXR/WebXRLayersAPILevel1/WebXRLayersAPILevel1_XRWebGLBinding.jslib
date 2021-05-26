
mergeInto(LibraryManager.library, {

    XRWebGLBinding_2 : function(session, context) {
        return _WebIDL2Unity.addReference(new XRWebGLBinding(_WebIDL2Unity.references[session], _WebIDL2Unity.references[context]));
    }
,

    XRWebGLBinding_CreateProjectionLayer : function(id, init) {
        var value = _WebIDL2Unity.references[id].createProjectionLayer(_WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_CreateQuadLayer : function(id, init) {
        var value = _WebIDL2Unity.references[id].createQuadLayer(_WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_CreateCylinderLayer : function(id, init) {
        var value = _WebIDL2Unity.references[id].createCylinderLayer(_WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_CreateEquirectLayer : function(id, init) {
        var value = _WebIDL2Unity.references[id].createEquirectLayer(_WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_CreateCubeLayer : function(id, init) {
        var value = _WebIDL2Unity.references[id].createCubeLayer(_WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_GetSubImage : function(id, layer, frame, eye) {
        var value = _WebIDL2Unity.references[id].getSubImage(_WebIDL2Unity.references[layer], _WebIDL2Unity.references[frame], _WebIDL2UnityEnums.XREye[eye]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLBinding_GetViewSubImage : function(id, layer, view) {
        var value = _WebIDL2Unity.references[id].getViewSubImage(_WebIDL2Unity.references[layer], _WebIDL2Unity.references[view]);
        return _WebIDL2Unity.addReference(value);
    }

});
