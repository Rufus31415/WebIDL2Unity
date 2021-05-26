
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XRHandJoint_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XRHandJoint[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XRHandJoint_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XRHandJoint[value];
    }
});
