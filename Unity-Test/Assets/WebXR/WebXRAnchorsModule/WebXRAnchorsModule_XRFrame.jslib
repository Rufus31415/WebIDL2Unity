
mergeInto(LibraryManager.library, {

    XRFrame_CreateAnchor : function(id, pose, space, callback) {
        var value = _WebIDL2Unity.references[id].createAnchor(_WebIDL2Unity.references[pose], _WebIDL2Unity.references[space]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }

});
