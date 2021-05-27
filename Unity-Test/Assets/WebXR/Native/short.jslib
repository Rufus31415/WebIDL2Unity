
mergeInto(LibraryManager.library, {
    WebIDL2Unity_short_get : function(parentID, fieldName){
       return _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)];;
    },
    WebIDL2Unity_short_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = value;
    }
});
