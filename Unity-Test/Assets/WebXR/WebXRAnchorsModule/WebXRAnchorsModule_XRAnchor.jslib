
mergeInto(LibraryManager.library, {

    XRAnchor_Delete : function(id) {
        _WebIDL2Unity.references[id].delete();
        
    }

});
