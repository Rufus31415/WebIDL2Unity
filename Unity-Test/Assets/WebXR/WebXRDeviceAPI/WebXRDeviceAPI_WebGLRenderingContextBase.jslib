
mergeInto(LibraryManager.library, {

    WebGLRenderingContextBase_MakeXRCompatible : function(id) {
        var value = _WebIDL2Unity.references[id].makeXRCompatible();
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
