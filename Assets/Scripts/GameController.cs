using UnityEngine;
using System.Runtime.InteropServices;

public class GameController : MonoBehaviour
{
  [DllImport("__Internal")]
  private static extern void NearLogin ();

  [DllImport("__Internal")]
  private static extern void FtTransfer (string receiverId, string amount);

  [DllImport("__Internal")]
  private static extern void FtBalanceOf (string accountId);

  public void NearLoginPub () {
#if UNITY_WEBGL == true && UNITY_EDITOR == false
    NearLogin();
#endif
  }

  public void FtTransferPub (string receiverId) {
#if UNITY_WEBGL == true && UNITY_EDITOR == false
    FtTransfer(receiverId, "1000000000000000000");
#endif
  }

  public void FtBalanceOfPub (string accountId) {
#if UNITY_WEBGL == true && UNITY_EDITOR == false
    FtBalanceOf(accountId);
#endif
  }
}
