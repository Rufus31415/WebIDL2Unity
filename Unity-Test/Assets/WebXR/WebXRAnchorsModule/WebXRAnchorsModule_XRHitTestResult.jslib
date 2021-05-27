
mergeInto(LibraryManager.library, {

    XRHitTestResult_CreateAnchor : function(id, callback) {
        var value = _WebIDL2Unity.references[id].createAnchor();
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }

});
