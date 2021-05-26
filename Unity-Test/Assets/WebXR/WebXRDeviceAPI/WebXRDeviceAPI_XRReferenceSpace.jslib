
mergeInto(LibraryManager.library, {

    XRReferenceSpace_GetOffsetReferenceSpace : function(id, originOffset) {
        var value = _WebIDL2Unity.references[id].getOffsetReferenceSpace(_WebIDL2Unity.references[originOffset]);
        return _WebIDL2Unity.addReference(value);
    }

});
