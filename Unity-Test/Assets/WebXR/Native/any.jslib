
mergeInto(LibraryManager.library, {
    WebIDL2Unity_any_get : function(parentID, fieldName){
       return WebIDL2UnityStringToPtr(_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]);
    },
    WebIDL2Unity_any_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = Pointer_stringify(value);
    }
});
