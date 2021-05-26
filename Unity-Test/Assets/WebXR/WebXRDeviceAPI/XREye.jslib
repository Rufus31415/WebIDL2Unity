
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XREye_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XREye[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XREye_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XREye[value];
    }
});
