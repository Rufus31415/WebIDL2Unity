
mergeInto(LibraryManager.library, {

    XRHitTestResult_GetPose : function(id, baseSpace) {
        var value = _WebIDL2Unity.references[id].getPose(_WebIDL2Unity.references[baseSpace]);
        return _WebIDL2Unity.addReference(value);
    }

});
