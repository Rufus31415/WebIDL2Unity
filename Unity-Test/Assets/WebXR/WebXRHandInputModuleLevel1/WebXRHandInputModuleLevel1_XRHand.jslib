
mergeInto(LibraryManager.library, {

    XRHand_Get : function(id, key) {
        var value = _WebIDL2Unity.references[id].get(_WebIDL2UnityEnums.XRHandJoint[key]);
        return _WebIDL2Unity.addReference(value);
    }

});
