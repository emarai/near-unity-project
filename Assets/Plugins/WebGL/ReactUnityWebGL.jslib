mergeInto(LibraryManager.library, {
  NearLogin: function () {
    window.dispatchReactUnityEvent(
      "NearLogin"
    );
  },
  FtTransfer: function (receiverId, amount) {
    window.dispatchReactUnityEvent(
      "FtTransfer",
      Pointer_stringify(receiverId),
      Pointer_stringify(amount)
    );
  },
  FtBalanceOf: function (accountId) {
    window.dispatchReactUnityEvent(
      "FtBalanceOf",
      Pointer_stringify(accountId)
    );
  }
});