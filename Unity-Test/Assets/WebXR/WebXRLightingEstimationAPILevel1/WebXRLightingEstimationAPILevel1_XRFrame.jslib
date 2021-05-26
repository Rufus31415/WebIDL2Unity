
mergeInto(LibraryManager.library, {

    XRFrame_GetLightEstimate : function(id, lightProbe) {
        var value = _WebIDL2Unity.references[id].getLightEstimate(_WebIDL2Unity.references[lightProbe]);
        return _WebIDL2Unity.addReference(value);
    }

});
