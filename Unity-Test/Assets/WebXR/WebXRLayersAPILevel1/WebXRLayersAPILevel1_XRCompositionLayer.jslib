
mergeInto(LibraryManager.library, {

    XRCompositionLayer_Destroy : function(id) {
        _WebIDL2Unity.references[id].destroy();
        
    }

});
