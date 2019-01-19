using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Security;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour, IStoreListener {

    public Text text;
    private string productID = "1000weapon"; // 설정한 상품 ID를 입력합니다.
    private IStoreController controller; // 인앱 결제를 위한 컨트롤러 객체입니다.

    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
        InitStore(); // 인앱 결제 모듈을 초기화합니다.
    }

    void InitStore()
    {
        // 환경설정 객체를 선언합니다.
        ConfigurationBuilder builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
        // 설정한 상품 ID를 인앱 결제 상품으로서 등록합니다.
        builder.AddProduct(productID, ProductType.Consumable, new IDs { { productID, GooglePlay.Name } });
        UnityPurchasing.Initialize(this, builder);
    }
    
    public void ButtonClick()
    {
        if(controller == null)
        {
            Debug.Log("결제 모듈이 초기화되지 않았습니다.");
        }
        else
        {
            controller.InitiatePurchase(productID);
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        this.controller = controller;
        Debug.Log("결제 모듈 초기화가 완료되었습니다.");
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("결제 모듈 초기화에 실패했습니다.");
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
    {
        bool success = true;
        // 아래 소스코드는 안드로이드(Android)에서 실행했을 때에만 정상적으로 동작합니다.
        CrossPlatformValidator validator = new CrossPlatformValidator(GooglePlayTangle.Data(), AppleTangle.Data(), Application.identifier);
        try
        {
            // 앱상에서 구매한 물품에 대하여 결제 처리를 진행합니다.
            IPurchaseReceipt[] result = validator.Validate(e.purchasedProduct.receipt);
            for(int i = 0; i < result.Length; i++)
            {
                Analytics.Transaction(productID, e.purchasedProduct.metadata.localizedPrice, e.purchasedProduct.metadata.isoCurrencyCode);
            }
        }
        catch (IAPSecurityException ex)
        {
            // 유니티 에디터에서 실행하는 경우 오류가 발생합니다.
            Debug.Log("오류 발생: " + ex.Message);
            success = false;
        }
        if(success)
        {
            text.text = "결제 완료";
        }
        else
        {
            text.text = "결제 실패";
        }
        return PurchaseProcessingResult.Complete;
    }

    public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
    {
        if(!p.Equals(PurchaseFailureReason.UserCancelled)) {
            Debug.Log("결제 모듈 동작에 실패했습니다.");
        }
        else {
            Debug.Log("사용자가 결제를 취소했습니다.");
        }
    }

}
