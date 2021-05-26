
mergeInto(LibraryManager.library, {

    XRSystem_IsSessionSupported : function(id, mode) {
        var value = _WebIDL2Unity.references[id].isSessionSupported(_WebIDL2UnityEnums.XRSessionMode[mode]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }
,

    XRSystem_RequestSession : function(id, mode, options) {
        var value = _WebIDL2Unity.references[id].requestSession(_WebIDL2UnityEnums.XRSessionMode[mode], _WebIDL2Unity.references[options]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
