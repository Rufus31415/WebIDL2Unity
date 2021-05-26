
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XREnvironmentBlendMode_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XREnvironmentBlendMode[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XREnvironmentBlendMode_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XREnvironmentBlendMode[value];
    }
});
