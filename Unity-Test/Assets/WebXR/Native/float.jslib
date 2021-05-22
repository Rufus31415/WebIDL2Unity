
mergeInto(LibraryManager.library, {
    WebIDL2Unity_float_get : function(parentID, fieldName){
       return _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)];
    },
    WebIDL2Unity_float_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = value;
    }
});
