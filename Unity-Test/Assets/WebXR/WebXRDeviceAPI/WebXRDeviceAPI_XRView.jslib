
mergeInto(LibraryManager.library, {

    XRView_RequestViewportScale : function(id, scale) {
        _WebIDL2Unity.references[id].requestViewportScale(scale);
        
    }

});
