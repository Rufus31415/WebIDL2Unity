
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XRReflectionFormat_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XRReflectionFormat[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XRReflectionFormat_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XRReflectionFormat[value];
    }
});
