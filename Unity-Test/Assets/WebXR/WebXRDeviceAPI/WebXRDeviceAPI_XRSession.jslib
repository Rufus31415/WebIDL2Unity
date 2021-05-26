
mergeInto(LibraryManager.library, {

    XRSession_UpdateRenderState : function(id, state) {
        _WebIDL2Unity.references[id].updateRenderState(_WebIDL2Unity.references[state]);
        
    }
,

    XRSession_RequestReferenceSpace : function(id, type) {
        var value = _WebIDL2Unity.references[id].requestReferenceSpace(_WebIDL2UnityEnums.XRReferenceSpaceType[type]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }
,

    XRSession_RequestAnimationFrame : function(id) {
        var value = _WebIDL2Unity.references[id].requestAnimationFrame();
        return _WebIDL2Unity.addReference(value);
    }
,

    XRSession_CancelAnimationFrame : function(id, handle) {
        _WebIDL2Unity.references[id].cancelAnimationFrame(handle);
        
    }
,

    XRSession_End : function(id) {
        var value = _WebIDL2Unity.references[id].end();
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
