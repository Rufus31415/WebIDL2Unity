
mergeInto(LibraryManager.library, {

    XRHitTestResult_CreateAnchor : function(id) {
        var value = _WebIDL2Unity.references[id].createAnchor();
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
