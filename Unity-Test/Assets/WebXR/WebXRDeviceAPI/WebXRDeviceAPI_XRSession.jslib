
mergeInto(LibraryManager.library, {

    XRSession_UpdateRenderState : function(id, state) {
        _WebIDL2Unity.references[id].updateRenderState(_WebIDL2Unity.references[state]);
        
    }
,

    XRSession_RequestReferenceSpace : function(id, type, callback) {
        var value = _WebIDL2Unity.references[id].requestReferenceSpace(_WebIDL2UnityEnums.XRReferenceSpaceType[type]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }
,

    XRSession_RequestAnimationFrame : function(id) {
        var value = _WebIDL2Unity.references[id].requestAnimationFrame();
        return value;
    }
,

    XRSession_CancelAnimationFrame : function(id, handle) {
        _WebIDL2Unity.references[id].cancelAnimationFrame(handle);
        
    }
,

    XRSession_End : function(id, callback) {
        var value = _WebIDL2Unity.references[id].end();
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(){
            Module["dynCall_vi"](callback, promise);
        });

        return promise;
    }

});
