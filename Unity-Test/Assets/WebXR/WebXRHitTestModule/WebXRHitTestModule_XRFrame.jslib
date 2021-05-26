
mergeInto(LibraryManager.library, {

    XRFrame_GetHitTestResults : function(id, hitTestSource) {
        var value = _WebIDL2Unity.references[id].getHitTestResults(_WebIDL2Unity.references[hitTestSource]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRFrame_GetHitTestResultsForTransientInput : function(id, hitTestSource) {
        var value = _WebIDL2Unity.references[id].getHitTestResultsForTransientInput(_WebIDL2Unity.references[hitTestSource]);
        return _WebIDL2Unity.addReference(value);
    }

});
