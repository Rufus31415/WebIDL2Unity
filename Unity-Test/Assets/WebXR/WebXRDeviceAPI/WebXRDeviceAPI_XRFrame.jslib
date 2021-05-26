
mergeInto(LibraryManager.library, {

    XRFrame_GetViewerPose : function(id, referenceSpace) {
        var value = _WebIDL2Unity.references[id].getViewerPose(_WebIDL2Unity.references[referenceSpace]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRFrame_GetPose : function(id, space, baseSpace) {
        var value = _WebIDL2Unity.references[id].getPose(_WebIDL2Unity.references[space], _WebIDL2Unity.references[baseSpace]);
        return _WebIDL2Unity.addReference(value);
    }

});
