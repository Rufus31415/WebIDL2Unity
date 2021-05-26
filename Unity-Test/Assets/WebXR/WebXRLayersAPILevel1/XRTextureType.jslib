
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XRTextureType_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XRTextureType[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XRTextureType_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XRTextureType[value];
    }
});
