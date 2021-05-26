
mergeInto(LibraryManager.library, {

    XRFrame_CreateAnchor : function(id, pose, space) {
        var value = _WebIDL2Unity.references[id].createAnchor(_WebIDL2Unity.references[pose], _WebIDL2Unity.references[space]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
