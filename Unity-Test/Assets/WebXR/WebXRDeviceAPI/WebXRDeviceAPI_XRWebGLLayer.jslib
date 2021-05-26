
mergeInto(LibraryManager.library, {

    XRWebGLLayer_3 : function(session, context, layerInit) {
        return _WebIDL2Unity.addReference(new XRWebGLLayer(_WebIDL2Unity.references[session], _WebIDL2Unity.references[context], _WebIDL2Unity.references[layerInit]));
    }
,

    XRWebGLLayer_GetViewport : function(id, view) {
        var value = _WebIDL2Unity.references[id].getViewport(_WebIDL2Unity.references[view]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRWebGLLayer_GetNativeFramebufferScaleFactor : function(id, session) {
        var value = _WebIDL2Unity.references[id].getNativeFramebufferScaleFactor(_WebIDL2Unity.references[session]);
        return _WebIDL2Unity.addReference(value);
    }

});
