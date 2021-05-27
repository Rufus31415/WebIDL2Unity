
mergeInto(LibraryManager.library, {

    XRSystem_IsSessionSupported : function(id, mode, callback) {
        var value = _WebIDL2Unity.references[id].isSessionSupported(_WebIDL2UnityEnums.XRSessionMode[mode]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, a0);
        });

        return promise;
    }
,

    XRSystem_RequestSession : function(id, mode, options, callback) {
        var value = _WebIDL2Unity.references[id].requestSession(_WebIDL2UnityEnums.XRSessionMode[mode], _WebIDL2Unity.references[options]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }

});
