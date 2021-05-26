
mergeInto(LibraryManager.library, {

    XRMediaBinding_1 : function(session) {
        return _WebIDL2Unity.addReference(new XRMediaBinding(_WebIDL2Unity.references[session]));
    }
,

    XRMediaBinding_CreateQuadLayer : function(id, video, init) {
        var value = _WebIDL2Unity.references[id].createQuadLayer(_WebIDL2Unity.references[video], _WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRMediaBinding_CreateCylinderLayer : function(id, video, init) {
        var value = _WebIDL2Unity.references[id].createCylinderLayer(_WebIDL2Unity.references[video], _WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRMediaBinding_CreateEquirectLayer : function(id, video, init) {
        var value = _WebIDL2Unity.references[id].createEquirectLayer(_WebIDL2Unity.references[video], _WebIDL2Unity.references[init]);
        return _WebIDL2Unity.addReference(value);
    }

});
