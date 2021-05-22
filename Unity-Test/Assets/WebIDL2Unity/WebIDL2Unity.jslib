mergeInto(LibraryManager.library, {
    WebIDL2UnityDeleteReference: function (id) {
        _WebIDL2Unity.deleteReference(id);
    },

    WebIDL2UnityGetNewDictionnary: function () {
        return _WebIDL2Unity.addReference({});
    },

    WebIDL2UnityGetNewArray: function () {
        return _WebIDL2Unity.addReference([]);
    }
});

