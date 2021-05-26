
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XRSessionMode_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XRSessionMode[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XRSessionMode_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XRSessionMode[value];
    }
});
