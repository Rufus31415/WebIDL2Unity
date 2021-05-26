
mergeInto(LibraryManager.library, {
    WebIDL2Unity_byte_get : function(parentID, fieldName){
       return _WebIDL2Unity.addReference(_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]);
    },
    WebIDL2Unity_byte_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = value;
    }
});
