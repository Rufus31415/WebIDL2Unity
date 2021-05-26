
mergeInto(LibraryManager.library, {

    XRWebGLBinding_GetReflectionCubeMap : function(id, lightProbe) {
        var value = _WebIDL2Unity.references[id].getReflectionCubeMap(_WebIDL2Unity.references[lightProbe]);
        return _WebIDL2Unity.addReference(value);
    }

});
